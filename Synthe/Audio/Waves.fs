// namespace SyntheAudio

module Waves 
    open System
    open XPlot.Plotly

    let sample x = (x + 1.)/2. * 255. |> byte
    let Pi = Math.PI
    let amp = 1.
    let freq = 100000.
    let sampleRate = 44100.
    let limit = int(sampleRate/(60./60.))
                    

    let sinbyte (ti:float) freq  = Array.init (int(float(limit)*ti)) (fun i -> 1. * sin((2. * freq * Pi * float i)/sampleRate) |> sample)
    let sinWave = Array.init limit (fun i -> amp * sin((2. * freq * Pi * float i)/sampleRate))
    let wavep =  Array.init limit (fun i -> amp * sin((2. * 1000. * Pi * float i)/sampleRate))
    let wavem =  Array.init limit (fun i -> amp * sin((2. * 10. * Pi * float i)/sampleRate))


    let triangleWave = Array.init limit  (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)))
    let trianglebyte = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)) |> sample)

    let squareWave = Array.init limit (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))))
    let squarebyte = Array.init limit (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))) |> sample)

    let sawWave = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)))
    let sawbyte = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)) |> sample)

    // let test (nom:float [] ) =  // The most unbelievable thing to play a song
    //     let mutable wave2 = sinbyte 1 0.
    //     for j in 0..firstSong.Length-1 do
    //         let delay = Array.init (int(sampleRate/100.)) (fun i -> 0. |> sample)
    //         let n = Array.init limit  (fun i -> amp * sin((2. * nom.[j] * Pi * float i)/sampleRate) |> sample)
    //         wave2 <- Array.concat[|wave2; delay; n|]
    //     wave2
