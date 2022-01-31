// namespace Synthe

// open System
// open System.IO
// open SyntheAudio
// // open SyntheCompress
// open SyntheVisual

// module Program =
//     [<EntryPoint>]
//     let main argv = 
//         //args["F", "White", "5"]
//         for arg in argv do
//             match arg with 
//             | "GoldenWind" 
//                 ->  GoldenWind |> ignore ; printfn "0"
//             | "Solvieg" 
//                 -> Solvieg |> ignore ; printfn "1"
//             | "SinWave"
//                 -> sinVisu "a" |> ignore ; printfn "a"
//             | "SqWave"
//                 -> SquareVisu "b" |> ignore ; printfn "b"
//             | "SawWave"
//                 -> sawVisu "c" |> ignore ; printfn "c"
//             | "TriangleWave"
//                 -> triVisu "d" |> ignore ; printfn "d"
//             | "ByFixedAMP"
//                 -> ampByFixedAmound "e" |> ignore ; printfn "e"
//             | "Overdrive"
//                 -> Overdrived "f" |> ignore ; printfn "f"
//             | "Envelope"
//                 -> Enveloped "g" |> ignore ; printfn "g"
//             | "Flange"
//                 -> Flanged "h" |> ignore ; printfn "h"
//             | "Chords"
//                 -> CombinedWaves "i" |> ignore ; printfn "i"
//             | "Echo"
//                 -> Echoed "j" |> ignore ; printfn "j"    
//             |_ 
//                 -> printfn "Unknown command"  |> ignore
//         0
