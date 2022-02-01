namespace SyntheAudio
open XPlot.Plotly
open MathNet.Filtering
open System
open System.IO
open Waves

module Effect =
    let time = 0.5

// Modify the wave’s amplitude by a fixed amount
    let ByFixedAmount (modifier:float) (wave:float array) =
        for i in 0..(Waves.limit-1) do
            wave.[i] <- wave.[i] * modifier
        wave

    // let newwave = byFixedAmount 3. sinWave
    // newwave |> Chart.Line |> Chart.Show

// Cut off the wave at specific amplitude to given the “overdriven” often used in rock songs
    let Overdrive (flatten:float) (wave: float array) limit =
        for i in 0..limit-1 do
            if wave.[i] > flatten then
                wave.[i] <- flatten
            elif wave.[i] < 0.0 - flatten then
                wave.[i] <- 0.0 - flatten

        wave

    // let sin = overdrive 0.7 sinWave (limit - 1)

    // sin |> Chart.Line |> Chart.Show

    let Enveloppe time amplitude At De Su Re =

        // Attack is the time taken for initial run-up of level from nil to peak, beginning when the key is pressed.
        let Attack = Array.init (int (time*sampleRate*At)) (fun i -> amplitude/(time*sampleRate*At)* float i)

        // Decay is the time taken for the subsequent run down from the attack level to the designated sustain level.
        let Decay = Array.init (int (time*sampleRate*De)) (fun i -> amplitude - (amplitude-Su*amplitude)/(time*sampleRate*De) *float i)

        // Sustain is the level during the main sequence of the sound's duration, until the key is released.
        let Sustain = Array.init (int (time*(sampleRate - sampleRate*Re - sampleRate*De - sampleRate*At))) (fun _ -> Su*amplitude)

        // Release is the time taken for the level to decay from the sustain level to zero after the key is released.
        let Release = Array.init (int (time*sampleRate*Re)) (fun i -> Su*amplitude - Su*amplitude/(time*sampleRate*Re) * float i)

        let amp = Array.concat [|Attack; Decay; Sustain; Release|]
        amp

    // let Amp = enveloppe 0.5 2 0.1 0.1 0.5 0.1

    // let sinus = Array.init (int(time)*limit) (fun i -> Amp.[i] * sin((freq/ Pi) * float i))

    // Amp |> Chart.Line |> Chart.Show

// Flanging is an audio effect produced by mixing two identical signals together, one signal delayed by a small and gradually changing period
    let Flange (wave:float array) = 
            [
            let maxTimeDelay = 0.003
            let speed = 1.

            let maxSampleDelay = int (maxTimeDelay * float sampleRate)
            let mutable currentDelay = 0

            let coefficient = 0.5
            let mutable currentSine = 0.

            for i in 0..wave.Length-1 do
                if i < maxSampleDelay+1 then yield wave.[i]
                else
                    currentSine <- abs(sin((Waves.freq/ Waves.Pi) * (float i) * (speed / (float sampleRate))))
                    currentDelay <- int(currentSine * (float maxSampleDelay))
                    yield (coefficient * wave.[i]) + (coefficient * wave.[i-currentDelay])
            ]
    // Flange(sinWave) |> Chart.Line  |> Chart.Show

    let addWaves = Array.map2(fun x y -> (x+y)/2.) Waves.sinWave Waves.squareWave
    // addWaves |> Chart.Line |> Chart.Show

// Reverberation or reverb, is a persistence of sound, or echo after a sound is produced
    let Reverb (wave: float []) reduc = 
        let mutable wave2 = wave
        let mutable amp2 = Waves.amp
        while amp2 * reduc > 0.1 do
            amp2 <- amp2 * reduc
            let r = Array.init (Waves.limit) (fun i -> amp2 * sin((2. * Waves.freq * Waves.Pi * float i)/sampleRate))
            let newWave = Array.concat [|wave2; r|]
            wave2 <- newWave
        wave2

    // reverb sinWave 0.6 |> Chart.Line |> Chart.Show

// In audio signal processing and acoustics, an echo is a reflection of sound that arrives at the listener with a delay after the direct sound
    let Echo (wave: float []) reduc (delay:float) = 
        let mutable wave2 = wave
        let mutable amp2 = Waves.amp
        while amp2 * reduc > 0.1 do
            amp2 <- amp2 * reduc
            let del = Array.init (int(delay * sampleRate))(fun i -> 0.)
            let e = Array.init (Waves.limit) (fun i -> amp2 * sin((2. * Waves.freq * Waves.Pi * float i)/sampleRate))
            let newWave = Array.concat [|wave2; del; e|]
            wave2 <- newWave
        wave2

    // echo sinWave 0.5 0.1 |> Chart.Line |> Chart.Show

// In amplitude modulation, the amplitude of the carrier wave is varied in proportion to that of the message signal, such as an audio signal
    let AM (wavep: float array) (wavem: float array) = 
        let newWave = Array.init 44100 (fun i -> wavem.[i] * wavep.[i])
        newWave

// Frequency modulation is the encoding of information in a carrier wave by varying the instantaneous frequency of the wave
    let FM (wavep: float array) (wavem: float array) =
        let newWave = Array.init 44100 (fun i -> 1. * sin((2. * Pi * 500. * float i/sampleRate) + (1./10.)*(500. - 10.) * wavem.[i]))
        newWave

// A low-pass filter is a filter that passes signals with a frequency lower than a selected cutoff frequency and attenuates signals with frequencies higher than the cutoff frequency
    let LowPassFilter (sinWave: float []) =
        let data = sinWave
        
        let lowPass = IIR.IirCoefficients.LowPass(44100., 2000., 1.);
        let filter = new IIR.OnlineIirFilter(lowPass);        
        let processed = filter.ProcessSamples(data);

        processed

// A high-pass filter is an electronic filter that passes signals with a frequency higher than a certain cutoff frequency and attenuates signals with frequencies lower than the cutoff frequency
    let highPassFilter (sinWave: float []) =
        let data = sinWave
        
        let highPass = IIR.IirCoefficients.HighPass(44100., 1000., 1.);
        let filter = new IIR.OnlineIirFilter(highPass);        
        let processed = filter.ProcessSamples(data);

        processed
