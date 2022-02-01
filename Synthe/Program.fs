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
            | "PlayFile"
                -> PlaySound |> ignore ; printfn "0"
            | "CrazyFrog"
                -> PlaySong(Crazy) |> ignore ; printfn "1"
            | "Gadjet"
                -> PlaySong(Gadjet) |> ignore ; printfn "3" 
            | "GoldenWind" 
                ->  PlaySong(GoldenWind) |> ignore ; printfn "4"
            | "InTheEnd"
                -> PlaySong(InTheEnd) |> ignore ; printfn "5"
            | "Kalinka"
                -> PlaySong(Kalinka) |> ignore ; printfn "6"
            | "Lac"
                -> PlaySong(Lac) |> ignore ; printfn "7"
            | "LVER"
                -> PlaySong(LVER) |> ignore ; printfn "8"
            | "Megalovania"
                -> PlaySong(Megalovania) |> ignore ; printfn "9"
            | "Mogus"
                -> PlaySong(Amogus) |> ignore ; printfn "10"
            | "Numb"
                -> PlaySong(Numb) |> ignore ; printfn "11"
            | "RR"
                -> PlaySong(RR) |> ignore ; printfn "12"        
            | "Solvieg" 
                -> PlaySong(Solvieg) |> ignore ; printfn "13"
            | "TOM"
                -> PlaySong(TOM) |> ignore ; printfn "14"
            | "Unravel"
                -> PlaySong(Unravel) |> ignore ; printfn "15"
            | "ZeldaOverworld"
                -> PlaySong(ZeldaOverworld) |> ignore ; printfn "16"
            | "LettreAElise"
                -> PlaySong(LettreAElise) |> ignore ; printfn "16"
            
            // | "ReadWOSave"
            //     ->  ignore ; printfn ""
            // | "SaveFile"
            //     ->  ignore ; printfn ""
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
                -> Reverbed "k" |> ignore ; printfn "k"   
            | "AM"
                -> AM "l" |> ignore ; printfn "l" 
            | "FM"
                -> FM "m" |> ignore ; printfn "m"
            | "HighPass"
                -> HighPass "n" |> ignore ; printfn "n"
            | "LowPass"
                -> LowPass "o" |> ignore ; printfn "o"
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
                            - Sus                   He does seems really sus...
                            - TriangleWave          Visualise a TriangleWave using GoogleCharts
                            - ByFixedAmount         Visualise a SinWave using GoogleCharts with amplitude modified by a fixed amount
                            - Overdrive             Visualise an overdriven sound
                            - Envelope              Visualise a SinWave using GoogleCharts modified with an Envelope (ADSR)
                            - Flange                Visualise a Flanged sound
                            - Chords                Visualise two waves using GoogleCharts combined to get a Chords
                            - Echo                  Visualise a echoed sound
                            - Reverb                Visualise a reverbed sound
                            - AM                    Visualise a SinWave using GoogleCharts modified amplitude modulation
                            - FM                    Visualise a SinWave using GoogleCharts modified frequency modulation
                            
                            "
            | "Sus"
                -> Mogus |> ignore ; printfn "

                                ░█░█░█░█░█▀▀░█▀█
                                ░█▄█░█▀█░█▀▀░█░█
                                ░▀░▀░▀░▀░▀▀▀░▀░▀
                                ░▀█▀░█░█░█▀▀
                                ░░█░░█▀█░█▀▀
                                ░░▀░░▀░▀░▀▀▀
                                ░▀█▀░█▄█░█▀█░█▀█░█▀▀░▀█▀░█▀█░█▀▄
                                ░░█░░█░█░█▀▀░█░█░▀▀█░░█░░█░█░█▀▄
                                ░▀▀▀░▀░▀░▀░░░▀▀▀░▀▀▀░░▀░░▀▀▀░▀░▀
                                ░▀█▀░█▀▀
                                ░░█░░▀▀█
                                ░▀▀▀░▀▀▀
                                ░█▀▀░█░█░█▀▀
                                ░▀▀█░█░█░▀▀█
                                ░▀▀▀░▀▀▀░▀▀▀

                                           ⣠⣤⣤⣤⣤⣤⣶⣦⣤⣄⡀        
                                        ⢀⣴⣿⡿⠛⠉⠙⠛⠛⠛⠛⠻⢿⣿⣷⣤⡀     
                                        ⣼⣿⠋       ⢀⣀⣀⠈⢻⣿⣿⡄    
                                       ⣸⣿⡏   ⣠⣶⣾⣿⣿⣿⠿⠿⠿⢿⣿⣿⣿⣄   
                                       ⣿⣿⠁  ⢰⣿⣿⣯⠁       ⠈⠙⢿⣷⡄ 
                                  ⣀⣤⣴⣶⣶⣿⡟   ⢸⣿⣿⣿⣆          ⣿⣷ 
                                 ⢰⣿⡟⠋⠉⣹⣿⡇   ⠘⣿⣿⣿⣿⣷⣦⣤⣤⣤⣶⣶⣶⣶⣿⣿⣿ 
                                 ⢸⣿⡇  ⣿⣿⡇    ⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃ 
                                 ⣸⣿⡇  ⣿⣿⡇     ⠉⠻⠿⣿⣿⣿⣿⡿⠿⠿⠛⢻⣿⡇  
                                 ⣿⣿⠁  ⣿⣿⡇                ⢸⣿⣧  
                                 ⣿⣿   ⣿⣿⡇                ⢸⣿⣿  
                                 ⣿⣿   ⣿⣿⡇                ⢸⣿⣿  
                                 ⢿⣿⡆  ⣿⣿⡇                ⢸⣿⡇  
                                 ⠸⣿⣧⡀ ⣿⣿⡇                ⣿⣿⠃  
                                  ⠛⢿⣿⣿⣿⣿⣇     ⣰⣿⣿⣷⣶⣶⣶⣶⠶ ⢠⣿⣿   
                                       ⣿⣿     ⣿⣿⡇ ⣽⣿⡏⠁  ⢸⣿⡇   
                                       ⣿⣿     ⣿⣿⡇ ⢹⣿⡆   ⣸⣿⠇   
                                       ⢿⣿⣦⣄⣀⣠⣴⣿⣿⠁ ⠈⠻⣿⣿⣿⣿⡿⠏    
                                       ⠈⠛⠻⠿⠿⠿⠿⠋⠁                
                            "
            |_ 
                -> printfn "Unknown command"  |> ignore
        0



