namespace Synthe
open System
open System.IO
open SyntheAudio
open SyntheCompress
open SyntheVisual
open Song
open Play
open Charts


module Program =
    [<EntryPoint>]
    let main argv = 
        //args["F", "White", "5"]
        for arg in argv do
            match arg with 
            | "GoldenWind" 
                ->  PlaySong(GoldenWind) |> ignore ; printfn "0"
            | "Solvieg" 
                -> PlaySong(Solvieg) |> ignore ; printfn "1"
            | "RR"
                -> PlaySong(RR) |> ignore ; printfn "2"
            | "Megalovania"
                -> PlaySong(Megalovania) |> ignore ; printfn "3"
            | "ZeldaOverworld"
                -> PlaySong(ZeldaOverworld) |> ignore ; printfn "4"
            | "Kalinka"
                -> PlaySong(Kalinka) |> ignore ; printfn "5"
            | "TOM"
                -> PlaySong(TOM) |> ignore ; printfn "6"
            | "CrazyFrog"
                -> PlaySong(Crazy) |> ignore ; printfn "7"
            | "SinWave"
                -> sinVisu "a" |> ignore ; printfn "a"
            | "SqWave"
                -> SquareVisu "b" |> ignore ; printfn "b"
            | "SawWave"
                -> sawVisu "c" |> ignore ; printfn "c"
            | "TriangleWave"
                -> triVisu "d" |> ignore ; printfn "d"
            | "ByFixedAMP"
                -> ampByFixedAmound "e" |> ignore ; printfn "e"
            | "Overdrive"
                -> Overdrived "f" |> ignore ; printfn "f"
            | "Envelope"
                -> Enveloped "g" |> ignore ; printfn "g"
            | "Flange"
                -> Flanged "h" |> ignore ; printfn "h"
            | "Chords"
                -> CombinedWaves "i" |> ignore ; printfn "i"
            | "Echo"
                -> Echoed "j" |> ignore ; printfn "j"   
            | "AM"
                -> AM "k" |> ignore ; printfn "k" 
            | "FM"
                -> FM "l" |> ignore ; printfn "l"
            |_ 
                -> printfn "Unknown command"  |> ignore
        0
