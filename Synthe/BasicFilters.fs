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

        open waves
        open XPlot.Plotly

        let sampleRate = 44100.
        let limit = 44100

        let enveloppe amplitude At De Su Re =

            let Attack = Array.init (int (sampleRate*At)) (fun i -> amplitude/(sampleRate*At)* float i)
            
            let Decay = Array.init (int (sampleRate*De)) (fun i -> amplitude - (amplitude-Su*amplitude)/(sampleRate*De) *float i)

            let Sustain = Array.init (int (sampleRate - sampleRate*Re - sampleRate*De - sampleRate*At)) (fun _ -> Su*amplitude)

            let Release = Array.init (int (sampleRate*Re)) (fun i -> Su*amplitude - Su*amplitude/(sampleRate*Re) * float i)

            let amp = Array.concat [|Attack; Decay; Sustain; Release|]
            amp

        let Amp = enveloppe 2 0.1 0.1 0.5 0.1

        let sinus = Array.init limit (fun i -> Amp[i] * sin((freq/ Pi) * float i))

        Amp |> Chart.Line |> Chart.Show

