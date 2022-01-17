module waves 
    open System
    open XPlot.GoogleCharts
    open SFML.Audio

    let sample x = (x + 1.)/2. * 255. |> byte
    let Pi = Math.PI
    let amp = 1.
    let freq = 440.
    let limit = 120000

    let sinWave = Array.init limit (fun i -> amp * sin((freq/ Pi) * float i))
    let sinbyte = Array.init limit (fun i -> amp * sin((freq/ Pi) * float i) |> sample)
    
    //sinWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show

    let triangle = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2.*Pi*float i)/freq)))
    let trianglebyte = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2.*Pi*float i)/freq)) |> sample)

    //triangle |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show

    let squareWave = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(freq/float limit)))))
    let squarebyte = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(freq/float limit)))) |> sample)

    //squareWave |> Chart.Line |> Chart.Show

    let sawWave = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)))
    let sawbyte = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)) |> sample)

    //sawWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show