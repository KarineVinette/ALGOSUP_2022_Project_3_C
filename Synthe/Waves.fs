<<<<<<< Updated upstream
﻿module waves =
=======
﻿module waves 

>>>>>>> Stashed changes
    open System
    open XPlot.GoogleCharts

    let sample x = (x + 1.)/2. * 255. |> byte
    let Pi = Math.PI
    let amp = 1.
    let freq = 40.
    let limit = 500

    let sinWave = Array.init limit (fun i -> amp * sin((freq/ Pi) * float i))
    
    sinWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show

    let triangle = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2.*Pi*float i)/freq)))

    triangle |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show

    let squareWave = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(freq/float limit)))))

    squareWave |> Chart.Line |> Chart.Show


    let sawWave = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)))

<<<<<<< Updated upstream
    sawWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
=======
    sawWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show

>>>>>>> Stashed changes
