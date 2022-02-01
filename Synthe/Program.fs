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
    let stream = File.Create("./Audio/CreatedSounds/soundTest3.wav") 
    CreateWavFile.write stream (SongAssemble Megalovania)

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
            | "InTheEnd"
                -> PlaySong(InTheEnd) |> ignore ; printfn "8"
            | "PlayFile"
                -> PlaySound |> ignore ; printfn "9"
            // | "ReadWOSave"
            //     ->  ignore ; printfn "10"
            // | "SaveFile"
            //     ->  ignore ; printfn "11"
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
            | "Reverb"
                -> Reverbed "k" |> ignore ; printfn "j"   
            | "AM"
                -> AM "k" |> ignore ; printfn "k" 
            | "FM"
                -> FM "l" |> ignore ; printfn "l"
            | "help"
                -> printfn  " 
                            All the commands should start with 'dotnet run <commandName>'

                            List of commands:
                            - help                  Show all the listed commands
                            - GoldenWind            Play the original theme from Jojo's Bizare Adventures part 5
                            - Solvieg               Play 'Solvieg song' from Peer Gynt
                            - RR                    Play 'Rick Roll, Never Gonna Give You Up'
                            - Megalovania           Play the original theme from the game 'Undertale' 
                            - Zelda                 Play the original theme from the game 'Zelda'
                            - Kalinka               Play the traditional russian song 'Kalinka' from 'Ivan Larionov'
                            - TOM                   Play 'A-ha, Take On Me'
                            - Crazy                 Play 'CrazyFrog' from 'Alex F'
                            - InTheEnd              Play 'In The End' from 'Linkin Park'
                            - PlayFile              Play a selected file
                            - PlayWOSave            Play a without saving to disk
                            - SaveFile              Save file on the disk in './Audio/CreatedSounds/SavedSound.wav'
                            - SinWave               Visualise a SinWave using GoogleCharts
                            - SqWave                Visualise a SquareWave using GoogleCharts
                            - SawWave               Visualise a SawToothWave using GoogleCharts
                            - TriangleWave          Visualise a TriangleWave using GoogleCharts
                            - ByFixedAmount         Visualise a sinWave using GoogleCharts with amplitude modified by a fixed amount
                            - Overdrive             Visualise an overdriven sound
                            - Envelope              Visualise a sinWave using GoogleCharts modified with an Envelope (ADSR)
                            - Flange                Visualise a Flanged sound
                            - Chords                Visualise two waves using GoogleCharts combined to get a Chords
                            - Echo                  Visualise a echoed sound
                            - Reverb                Visualise a reberved sound
                            - AM                    Visualise a sinWave using GoogleCharts modified amplitude modulation
                            - FM                    Visualise a sinWave using GoogleCharts modified frequency modulation
                            
                            "
            | "HighPass"
                -> HighPass "m" |> ignore ; printfn "m"
            | "LowPass"
                -> LowPass "m" |> ignore ; printfn "m"
            |_ 
                -> printfn "Unknown command"  |> ignore
        0



