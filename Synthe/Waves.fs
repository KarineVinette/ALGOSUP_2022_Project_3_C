module waves 
    open System
    open XPlot.GoogleCharts

    let sample x = (x + 1.)/2. * 255. |> byte
    let Pi = Math.PI
    let amp = 1.
    let freq = 40.
    let limit = 500


    type Note  =
        | A
        | A#
        | B
        | C
        | C#
        | D
        | D#
        | E
        | F
        | F#
        | G
        | G#

    let NotesValues note  = 
                match note with
                | A -> 440.
                | A# -> 466.16
                | B -> 493.88
                | C -> 261.63
                | C# -> 277.18 
                | D -> 293.66
                | D# -> 311.13
                | E -> 329.63
                | F -> 349.23
                | F# -> 369.99
                | G -> 392.
                | G# -> 415.31

    let sinWave = Array.init limit (fun i -> amp * sin((freq/ Pi) * float i))
    
    //sinWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show

    let triangle = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2.*Pi*float i)/freq)))

    //triangle |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show

    let squareWave = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(freq/float limit)))))

    //squareWave |> Chart.Line |> Chart.Show


    let sawWave = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)))

    //sawWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
