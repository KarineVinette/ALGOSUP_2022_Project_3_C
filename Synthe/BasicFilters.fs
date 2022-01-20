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

        sin |> Chart.Line |> Chart.Show


