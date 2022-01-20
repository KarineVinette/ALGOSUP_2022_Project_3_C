module BasicFilters

    module overdrive =

        open waves
        open XPlot.Plotly

        let overdrive (flatten:float) (wave: float array) limit =

            for i in 0..limit do
                if wave.[i] > flatten then
                    wave.[i] <- flatten
                elif wave.[i] < 0.0 - flatten then
                    wave.[i] <- 0.0 - flatten

            wave

        let sin = overdrive 0.7 sinWave (limit - 1)

        //sin |> Chart.Line |> Chart.Show


    module enveloppe =


        open System
        open System.IO
        open XPlot.Plotly

        let sampleRate = 44100.
        let Pi = Math.PI
        let amplitude = 2.
        let Frequency = 440.
        let limit = 44100

        let enveloppe amplitude A D S R =

            let Attack = Array.init (int (sampleRate*A)) (fun i -> amplitude/(sampleRate*A)* float i)
            
            let Decay = Array.init (int (sampleRate*D)) (fun i -> amplitude - (amplitude-S*amplitude)/(sampleRate*D) *float i)

            let Sustain = Array.init (int (sampleRate - sampleRate*R - sampleRate*D - sampleRate*A)) (fun _ -> S*amplitude)

            let Release = Array.init (int (sampleRate*R)) (fun i -> S*amplitude - S*amplitude/(sampleRate*R) * float i)

            let amp = Array.concat [|Attack; Decay; Sustain; Release|]
            amp

        let Amp = enveloppe 2 0.1 0.1 0.5 0.1

        let sinus = Array.init limit (fun i -> Amp[i] * sin((Frequency/ Pi) * float i))

        Amp |> Chart.Line |> Chart.Show

