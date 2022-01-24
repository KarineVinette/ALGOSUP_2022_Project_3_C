// namespace SyntheAudio

module Waves 
    open System

    let sample x = (x + 1.)/2. * 255. |> byte
    let Pi = Math.PI
    let amp = 10.
    let freq = 40.
    let limit = 500


    let sinWave = Array.init limit (fun i -> amp * sin((freq/ Pi) * float i))
    let sinbyte = Array.init limit (fun i -> amp * sin((freq/ Pi) * float i) |> sample)

    let triangleWave = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2.*Pi*float i)/freq)))
    let trianglebyte = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2.*Pi*float i)/freq)) |> sample)

    let squareWave = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(freq/float limit)))))
    let squarebyte = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(freq/float limit)))) |> sample)

    let sawWave = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)))
    let sawbyte = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)) |> sample)
