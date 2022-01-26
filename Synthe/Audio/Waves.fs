// namespace SyntheAudio

module Waves 
    open System
    open Note
    open XPlot.Plotly

    let sample x = (x + 1.)/2. * 255. |> byte
    let Pi = Math.PI
    let amp = 1.
    let freq  = NotesValues A 4 // Note are from A to G 
    let limit = 44100
    let sampleRate = 44100.
    let noteArray = [|NotesValues C 4; NotesValues D 4; NotesValues E 4; NotesValues F 4; NotesValues G 4; NotesValues A 4; NotesValues B 4; NotesValues C 6; NotesValues C 1; |]

    let sinbyte freq amp = Array.init limit (fun i -> amp * sin((2. * freq * Pi * float i)/sampleRate) |> sample)
    let sinWave =  Array.init limit (fun i -> amp * sin((2. * freq * Pi * float i)/sampleRate))


    let triangleWave = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)))
    let trianglebyte = Array.init limit (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)) |> sample)

    let squareWave = Array.init limit (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))))
    let squarebyte = Array.init limit (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))) |> sample)

    let sawWave = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)))
    let sawbyte = Array.init limit (fun i -> (2.*amp/Pi)* Math.Atan(tan((2.*Pi*float i)/freq)) |> sample)



    let test (nom:float [] ) =  // The most unbelievable thing to play a song
        let mutable wave2 = sinbyte 0. 0.
        for j in 0..noteArray.Length-1 do
            let n = Array.init limit (fun i -> amp * sin((2. * nom.[j] * Pi * float i)/sampleRate) |> sample)
            wave2 <- Array.concat[|wave2; n|]
        wave2

