namespace SyntheVisual
open XPlot.GoogleCharts
open SyntheAudio


module Charts =
  // 4 basic waves
  let sinVisu title = 
    let options =
      Options
        ( 
        title = "Sinusoidal Wave", 
        curveType = "function",
        vAxis = Axis(title = "Amplitude"),
        hAxis = Axis(title = "Frequency")
        )
    Waves.sinWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

  let SquareVisu title = 
    let options =
      Options
        ( 
        title = "Square Wave",
        vAxis = Axis(title = "Amplitude"),
        hAxis = Axis(title = "Frequency")
        )
    Waves.squareWave |> Chart.Line |> Chart.WithOptions options  |> Chart.Show

  let sawVisu title = 
    let options =
          Options
            (
            title = "Sawtooth Wave",
            vAxis = Axis(title = "Amplitude"),
            hAxis = Axis(title = "Frequency")
            )
    Waves.sawWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

  let triVisu title = 
    let options =
            Options
              (
              title = "Sawtooth Wave",
              vAxis = Axis(title = "Amplitude"),
              hAxis = Axis(title = "Frequency")
              )
    Waves.triangleWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

  //filters
  let ampByFixedAmound title =
    let options =
            Options
              (
              title = " Modified amp by a fixed amount Sin Wave",
              vAxis = Axis(title = "Amplitude"),
              hAxis = Axis(title = "Frequency")
              )
    Effect.ByFixedAmount 3. Waves.sinWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

  let Overdrived title =
    let options =
            Options
              (
              title = " Overdrived Sin Wave",
              vAxis = Axis(title = "Amplitude"),
              hAxis = Axis(title = "Frequency")
              )
    Effect.Overdrive 0.6 Waves.sinWave 44100 |> Chart.Line |> Chart.WithOptions options |> Chart.Show

  let Enveloped title=
    let options =
            Options
              (
              title = " Enveloped Sin Wave",
              vAxis = Axis(title = "Amplitude"),
              hAxis = Axis(title = "Frequency")
              )
    Effect.Enveloppe 1. 2. 0.1 0.1 0.5 0.1 |> Chart.Line |> Chart.WithOptions options |> Chart.Show
    
  let Flanged title=
    let options =
            Options
              (
              title = " Flanged Sin Wave",
              vAxis = Axis(title = "Amplitude"),
              hAxis = Axis(title = "Frequency")
              )

    Effect.Flange(Waves.sinWave) |> Chart.Line  |> Chart.WithOptions options |> Chart.Show

  let CombinedWaves title=
    let options =
            Options
              (
              title = " Combined Waves Sin Wave",
              vAxis = Axis(title = "Amplitude"),
              hAxis = Axis(title = "Frequency")
              )

    Effect.addWaves |> Chart.Line |> Chart.WithOptions options |> Chart.Show
    
  let Echoed title=
    let options =
            Options
              (
              title = " Echoed Sin Wave",
              vAxis = Axis(title = "Amplitude"),
              hAxis = Axis(title = "Frequency")
              )

    Effect.Echo Waves.sinWave 0.5 0.1 |> Chart.Line |> Chart.WithOptions options |> Chart.Show 

  // porteuse |> Chart.Line |> Chart.WithOptions(Options(curveType = "function"))|> Chart.Show
  // modulante |> Chart.Line |> Chart.WithOptions(Options(curveType = "function"))|> Chart.Show
  // LowFrequencyOscillator.AM porteuse modulante |> Chart.Line |> Chart.WithOptions(Options(curveType = "function"))|> Chart.Show

  // sinWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // triangleWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // squareWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // sawWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
