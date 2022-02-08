namespace SyntheAudio
open System

module Waves =

    let sample x = (x + 1.)/2. * 255. |> byte
    let unsample (x:byte) = ((float x) /255. * 2. - 1.) 

    let Pi = Math.PI // π = 3.14159265359...
    let amp = 1. // Amplitude
    let freq = 10. // Frequence
    let sampleRate = 44100. // = 1 second
    let mutable t = 60.

    let Tempo (t:float) = sampleRate/(t/60.) // Tempo

    let sinbyte (ti:float) freq  = Array.init (int(t * ti)) (fun i -> 1. * sin((2. * freq * Pi * float i)/sampleRate) |> sample)
    let sinWave = Array.init 44100 (fun i -> amp * sin((2. * freq * Pi * float i)/sampleRate))
    let wavep =  Array.init 44100 (fun i -> amp * sin((2. * 1000. * Pi * float i)/sampleRate))
    let wavem =  Array.init 44100 (fun i -> 0.7 * sin((2. * 10. * Pi * float i)/sampleRate))


    let triangleWave = Array.init 44100  (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)))
    let trianglebyte = Array.init 44100 (fun i ->  (2.*amp/Pi)* Math.Asin(sin((2. * freq * Pi * float i)/sampleRate)) |> sample)

    let squareWave = Array.init 44100 (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))))
    let squarebyte = Array.init 44100 (fun i -> amp * float(Math.Sign(sin((2. * freq * Pi * float i)/sampleRate))) |> sample)

    let sawWave = Array.init 44100 (fun i -> (2.*amp/Pi)* Math.Atan(tan((Pi*float i*freq)/sampleRate)))
    let sawbyte = Array.init 44100 (fun i -> (2.*amp/Pi)* Math.Atan(tan((Pi*float i*freq)/sampleRate)) |> sample)
