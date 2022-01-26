// namespace SyntheAudio

module Waves 
    open System
    open Note
    open XPlot.Plotly

    let sample x = (x + 1.)/2. * 255. |> byte
    let Pi = Math.PI
    let amp = 1.
    let freq = NotesValues A 4
    let limit = 44100
    let sampleRate = 44100.

    let sinbyte = Array.init limit (fun i -> amp * sin((2. * freq * Pi * float i)/sampleRate) |> sample)
    let sinWave =  Array.init limit (fun i -> amp * sin((2. * freq * Pi * float i)/sampleRate))

    let triangleWave = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)))
    let trianglebyte = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)) |> sample)

    let squareWave = Array.init limit (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))))
    let squarebyte = Array.init limit (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))) |> sample)

    let sawWave = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)))
    let sawbyte = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)) |> sample)