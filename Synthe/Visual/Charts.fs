module Charts 

  open XPlot.Plotly
  open Waves
  open BasicFilters
  
  // 4 basic waves
  // sinWave |> Chart.Line |> Chart.Show
  // squareWave |> Chart.Line |> Chart.Show
  // sawWave |> Chart.Line |> Chart.Show
  // triangleWave |> Chart.Line |> Chart.Show

  //filters
  // byFixedAmount.byFixedAmount 3 sinWave |> Chart.Line |> Chart.Show

  //overdrive.overdrive 0.6 sinWave 44100 |> Chart.Line |> Chart.Show

  // enveloppe.enveloppe 1 2 0.1 0.1 0.5 0.1 |> Chart.Line |> Chart.Show

  //Flange.Flange(sinWave) |> Chart.Line  |> Chart.Show

  // Chords.addWaves |> Chart.Line |> Chart.Show
  // echo.echo sinWave 0.5 0.1 |> Chart.Line |> Chart.Show 

  // porteuse |> Chart.Line |> Chart.WithOptions(Options(curveType = "function"))|> Chart.Show
  // modulante |> Chart.Line |> Chart.WithOptions(Options(curveType = "function"))|> Chart.Show
  // LowFrequencyOscillator.AM porteuse modulante |> Chart.Line |> Chart.WithOptions(Options(curveType = "function"))|> Chart.Show

  // sinWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // triangleWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // squareWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // sawWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
