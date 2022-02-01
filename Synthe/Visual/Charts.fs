namespace SyntheVisual
open XPlot.GoogleCharts
open SyntheAudio
open Waves
open Effect

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
      sinWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let SquareVisu title = 
      let options =
        Options
          ( 
          title = "Square Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      squareWave |> Chart.Line |> Chart.WithOptions options  |> Chart.Show

    let sawVisu title = 
      let options =
        Options
          (
          title = "Sawtooth Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      sawWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let triVisu title = 
      let options =
        Options
          (
          title = "Triangle Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      triangleWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    // Filters
    let ampByFixedAmound title=
      let options =
        Options
          (
          title = " Modified amp by a fixed amount Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      ByFixedAmount 3. sinWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let Overdrived title=
      let options =
        Options
          (
          title = " Overdrived Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Overdrive 0.6 sinWave  |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let Enveloped title=
      let options =
        Options
          (
          title = " Enveloped Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Enveloppe 1. 2. 0.1 0.1 0.5 0.1 |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let Flanged title=
      let options =
        Options
          (
          title = " Flanged Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Flange(sinWave) |> Chart.Line  |> Chart.WithOptions options |> Chart.Show

    let CombinedWaves title=
      let options =
        Options
          (
          title = " Combined Waves Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      addWaves |> Chart.Line |> Chart.WithOptions options |> Chart.Show
      
    let Echoed title=
      let options =
        Options
          (
          title = " Echoed Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Echo sinWave 0.5 0.1 |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let Reverbed title =
      let options =
        Options
          (
          title = " Reverbed Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Reverb sinWave 2. |> Chart.Line |> Chart.WithOptions options |> Chart.Show 

    let AM title = 
      let options =
        Options
          (
          title = " AM",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      AM wavep wavem |> Chart.Line |> Chart.Show

    let FM title = 
      let options =
        Options
          (
          title = " FM",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      FM wavep wavem |> Chart.Line |> Chart.Show

    let HighPass title =
      let options =
        Options
          (
          title = " HighPass",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      highPassFilter sinWave |> Chart.Line |> Chart.Show

    let LowPass title =
      let options =
        Options
          (
          title = " HighPass",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      LowPassFilter sinWave |> Chart.Line |> Chart.Show