namespace SyntheVisual
open XPlot.GoogleCharts
open SyntheAudio
open Waves
open Effect

module Charts =
    // 4 basic waves
    let sinVisu() = 
      let options =
        Options
          ( 
          title = "Sinusoidal Wave", 
          curveType = "function",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      sinWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let SquareVisu() = 
      let options =
        Options
          ( 
          title = "Square Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      squareWave |> Chart.Line |> Chart.WithOptions options  |> Chart.Show

    let sawVisu() = 
      let options =
        Options
          (
          title = "Sawtooth Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      sawWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let triVisu() = 
      let options =
        Options
          (
          title = "Triangle Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      triangleWave |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    // Filters
    let ampByFixedAmound()=
      let options =
        Options
          (
          title = " Modified amp by a fixed amount Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      ByFixedAmount 3. (sinbyte 1. 100.) |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let Overdrived()=
      let options =
        Options
          (
          title = " Overdrived Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Overdrive 0.6 (sinbyte 1. 100.)   |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let Enveloped()=
      let options =
        Options
          (
          title = " Enveloped Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Enveloppe 1. 2. 0.1 0.1 0.5 0.1 |> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let Flanged()=
      let options =
        Options
          (
          title = " Flanged Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Flange((sinbyte 1. 100.)) |> Chart.Line  |> Chart.WithOptions options |> Chart.Show

    let CombinedWaves()=
      let options =
        Options
          (
          title = " Combined Waves Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      addWaves (sinbyte 1. 440.) (sinbyte 1. 261.26)|> Chart.Line |> Chart.WithOptions options |> Chart.Show
      
    let Echoed()=
      let options =
        Options
          (
          title = " Echoed Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Echo 0.1 0.5 (sinbyte 1. 100.)|> Chart.Line |> Chart.WithOptions options |> Chart.Show

    let Reverbed() =
      let options =
        Options
          (
          title = " Reverbed Sin Wave",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      Reverb 2. (sinbyte 1. 100.)  |> Chart.Line |> Chart.WithOptions options |> Chart.Show 

    let AM() = 
      let options =
        Options
          (
          title = " AM",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      AM wavep wavem |> Chart.Line |> Chart.Show

    let FM() = 
      let options =
        Options
          (
          title = " FM",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      FM wavep wavem |> Chart.Line |> Chart.Show

    let HighPass() =
      let options =
        Options
          (
          title = " HighPass",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      highPassFilter sinWave |> Chart.Line |> Chart.Show

    let LowPass() =
      let options =
        Options
          (
          title = " HighPass",
          vAxis = Axis(title = "Amplitude"),
          hAxis = Axis(title = "Frequency")
          )
      LowPassFilter sinWave |> Chart.Line |> Chart.Show
