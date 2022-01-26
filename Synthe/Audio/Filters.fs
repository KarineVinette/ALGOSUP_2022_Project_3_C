module BasicFilters
    open Waves
    open XPlot.Plotly
    open System
    open System.IO

    module byFixedAmount =

        let byFixedAmount (modifier:float) (wave:float array) =
            for i in 0..(limit-1) do
                wave.[i] <- wave.[i] * modifier
            wave

        // let newwave = byFixedAmount 3. sinWave
        // newwave |> Chart.Line |> Chart.Show

    module overdrive =

        let overdrive (flatten:float) (wave: float array) limit =

            for i in 0..limit do
                if wave.[i] > flatten then
                    wave.[i] <- flatten
                elif wave.[i] < 0.0 - flatten then
                    wave.[i] <- 0.0 - flatten

            wave

        //let sin = overdrive 0.7 sinWave (limit - 1)

        //sin |> Chart.Line |> Chart.Show

    module enveloppe =

        let sampleRate = 44100.
        let limit = 44100
        let time = 0.5

        let enveloppe time amplitude At De Su Re =

            let Attack = Array.init (int (time*sampleRate*At)) (fun i -> amplitude/(time*sampleRate*At)* float i)
            
            let Decay = Array.init (int (time*sampleRate*De)) (fun i -> amplitude - (amplitude-Su*amplitude)/(time*sampleRate*De) *float i)

            let Sustain = Array.init (int (time*(sampleRate - sampleRate*Re - sampleRate*De - sampleRate*At))) (fun _ -> Su*amplitude)

            let Release = Array.init (int (time*sampleRate*Re)) (fun i -> Su*amplitude - Su*amplitude/(time*sampleRate*Re) * float i)

            let amp = Array.concat [|Attack; Decay; Sustain; Release|]
            amp

        // let Amp = enveloppe 0.5 2 0.1 0.1 0.5 0.1

        // let sinus = Array.init (int(time)*limit) (fun i -> Amp.[i] * sin((freq/ Pi) * float i))

        // Amp |> Chart.Line |> Chart.Show

    module Flange =
        let sampleRate = 44100

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
                        currentSine <- abs(sin((freq/ Pi) * (float i) * (speed / (float sampleRate))))
                        currentDelay <- int(currentSine * (float maxSampleDelay))
                        yield (coefficient * wave.[i]) + (coefficient * wave.[i-currentDelay])
                ]
        // Flange(sinWave) |> Chart.Line  |> Chart.Show

    module Chords = 
        let addWaves = Array.map2(fun x y -> (x+y)/2.) triangleWave squareWave
        //addWaves |> Chart.Line |> Chart.Show
    
    module reverb =

        let sampleRate = 44100.
        let reverb (wave: float []) reduc = 
            let mutable wave2 = wave
            let mutable amp2 = amp
            while amp2 > 0.1 do
                amp2 <- amp2 * reduc
                let r = Array.init (limit) (fun i -> amp2 * sin((freq / Pi) * float i))
                let newWave = Array.concat [|wave2; r|]
                wave2 <- newWave
            wave2

        // reverb sinWave 0.6 |> Chart.Line |> Chart.Show

    module echo = 

        let sampleRate = 44100.
        let echo (wave: float []) reduc (delay:float) = 
            let mutable wave2 = wave
            let mutable amp2 = amp
            while amp2 > 0.1 do
                amp2 <- amp2 * reduc
                let del = Array.init (int(delay * sampleRate))(fun i -> 0.)
                let e = Array.init (limit) (fun i -> amp2 * sin((freq / Pi) * float i))
                let newWave = Array.concat [|wave2; del; e|]
                wave2 <- newWave
            wave2

        // echo sinWave 0.6 0.001 |> Chart.Line |> Chart.Show

    module LowFrequencyOscillator =

        // let AM (wave:float array) maxAmp minAmp =
        //     let mutable multiplicator = amp
        //     while multiplicator in 0..maxAmp do 
        //         if multiplicator < maxAmp then
        //             multiplicator <- multiplicator + 0.1
        //         else

        //     while multiplicator in 0..minAmp do
        //         if multiplicator > minAmp  then
        //             multiplicator <- multiplicator - 0.1

        let AM (wave:float array) maxAmp minAmp =
            let mutable multiplicator:float = amp
            let mutable count = 0
            let sampleRate = 44100.
            while multiplicator < maxAmp + 1. && count < limit-1 do 
                if multiplicator < maxAmp then
                    multiplicator <- multiplicator + 0.1
                else
                    if multiplicator > minAmp then
                        multiplicator <- multiplicator - 0.1
                // wave.[count] <- multiplicator * sin((2. * freq * Pi) / sampleRate)
                count <- count + 1
            wave