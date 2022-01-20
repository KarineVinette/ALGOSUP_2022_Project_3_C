module overdrive =

    open System
    //open waves
    //open XPlot.Plotly
    
    let Pi = Math.PI
    let amp = 1.
    let freq = 440.
    let limit = 120000

    let sinWave = Array.init limit (fun i -> amp * sin((freq/ Pi) * float i))

    let overdrive (flatten:float) (wave: float array) limit =

        for i in 0..limit do
            if wave.[i] > flatten then
                wave.[i] <- flatten
            elif wave.[i] < -flatten then
                wave.[i] <- -flatten

        sinWave

    let sin = overdrive 0.7 sinWave (limit - 1)

    //sin |> Chart.Line |> Chart.Show