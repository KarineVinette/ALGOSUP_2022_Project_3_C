namespace Synthe

open XPlot.Plotly
open XPlot.GoogleCharts
open Waves
    
module Charts =

  sinWave |> Chart.Line |> Chart.Show
  squareWave |> Chart.Line |> Chart.Show
  sawWave |> Chart.Line |> Chart.Show
  triangleWave |> Chart.Line |> Chart.Show

  // sinWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // triangle |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // squareWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
  // sawWave |> Chart.Line |> Chart.WithOptions(Options(curveType = "function")) |> Chart.Show
    