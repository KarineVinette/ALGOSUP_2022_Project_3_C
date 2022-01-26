namespace Synthe

open XPlot.Plotly
// open XPlot.GoogleCharts
open Waves
open BasicFilters
    
module Charts =
  // 4 basic waves
    sinWave |> Chart.Line |> Chart.Show
    squareWave |> Chart.Line |> Chart.Show
    sawWave |> Chart.Line |> Chart.Show
    triangleWave |> Chart.Line |> Chart.Show

  //filters
  // byFixedAmount.newwave |> Chart.Line |> Chart.Show

  // overdrive.sin |> Chart.Line |> Chart.Show

  // enveloppe.Amp |> Chart.Line |> Chart.Show

  // Flange.Flange(sinWave) |> Chart.Line  |> Chart.Show

  // Chords.addWaves |> Chart.Line |> Chart.Show

  LowFrequencyOscillator.AM sinWave 8. 0.1 |> Chart.Line |> Chart.Show


  // sinWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // triangleWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // squareWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // sawWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
