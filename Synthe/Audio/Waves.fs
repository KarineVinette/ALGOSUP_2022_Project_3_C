namespace SyntheAudio
open System

module Waves =

    let sample x = (x + 1.)/2. * 255. |> byte
    let Pi = Math.PI
    let amp = 1.
    let freq = 440.
    let sampleRate = 44100.
    let limit = int(sampleRate/(125./60.))
                    

    let sinbyte (ti:float) freq  = Array.init (int(float(limit)*ti)) (fun i -> 1. * sin((2. * freq * Pi * float i)/sampleRate) |> sample)
    let sinWave = Array.init limit (fun i -> amp * sin((2. * freq * Pi * float i)/sampleRate))
    // let porteuse =  Array.init limit (fun i -> amp * sin((2. * 50000. * Pi * float i)/sampleRate))
    // let modulante =  Array.init limit (fun i -> amp * sin((2. * 1000. * Pi * float i)/sampleRate))


    let triangleWave = Array.init limit  (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)))
    let trianglebyte = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)) |> sample)

    let squareWave = Array.init limit (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))))
    let squarebyte = Array.init limit (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))) |> sample)

    let sawWave = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)))
    let sawbyte = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)) |> sample)
