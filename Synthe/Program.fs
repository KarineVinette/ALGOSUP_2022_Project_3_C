namespace Synthe

open System
open System.IO
open SyntheAudio
open SyntheCompress
open SyntheVisual
open Song
open Play
open Charts
open Url

module Program =

    let  arrCom(name: string) =
        match name with
            | "SinWave" -> sinVisu()
            | "SqWave" -> SquareVisu()
            | "SawWave" -> sawVisu()
            // | "Sus" ->
            // | "TriangleWave" ->
            // | "ByFixedAmount" ->
            // | "Overdrive" ->
            // | "Envelope" ->
            // | "Flange" ->
            // | "Chords" ->
            // | "Echo" ->
            // | "Reverb" ->
            // | "AM" ->
            // | "FM" ->
            |_ -> printfn "no match found"

    let searchMusic (name: string) =
        match name with
        | "GoldenWind" -> GoldenWind
        | "InTheEnd" -> InTheEnd
        | "Lac" -> Lac
        | "Solvieg" -> Solvieg
        | "Gadjet" -> Gadjet
        | "Unravel" -> Unravel
        | "LVER" -> LVER
        | "Kalinka" -> Kalinka
        | "RR" -> RR
        | "Sus" -> Amogus
        | "Megalovania" -> Megalovania
        | "TOM" -> TOM
        | "ZeldaOverworld" -> ZeldaOverworld
        | "Crazy" -> Crazy
        | _ -> raise (System.Exception("The song name is not valid / or doesn't exist, please try again"))
    

    let commands (name : string) =
        match name with
        | "Mogus"-> PlaySong(Amogus)
        | "PlayFile"-> 
                Console.Write("Enter a valid path to your file: ")
                let url = Console.ReadLine()
                PlayURL url |> ignore
        | "PlaySong"-> 
                Console.Write("Enter your music name : ")
                let name = Console.ReadLine()
                PlaySong(searchMusic (name)) 
        | "SaveFile"-> 
                Console.Write("Enter your filename to save : ")
                let file = Console.ReadLine()

                let stream =
                    File.Create($"./Audio/CreatedSounds/{file}.wav")

                CreateWavFile.write stream (SongAssemble(searchMusic (file)))
        | "SinWave"-> 
            sinVisu()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            arrCom message |> ignore 
        | "SquareWave"-> SquareVisu()
        | "SawWave"->
            sawVisu()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            arrCom message |> ignore 
        | "TriangleWave"-> triVisu()
        | "ByFixedAMP"-> ampByFixedAmound()
        | "Overdrive"-> Overdrived()
        | "Envelope"-> Enveloped()
        | "Flange"-> Flanged()
        | "Chords"-> CombinedWaves()
        | "Echo"-> Echoed()
        | "Reverb"-> Reverbed()
        | "AM"-> AM()
        | "FM"-> FM()
        | "HighPass"-> HighPass()
        | "LowPass" -> LowPass()   
        | "help" ->
                printfn
                    "
                    All the commands should start with 'dotnet run <commandName>'.

                    List of commands:
                    - help                  Show all the listed commands
                    - songs                 List all the songs you can play using 'dotnet run PlaySong'
                    - PlaySong              Play selected song from the 'Song's list
                    - PlayFile              Play a selected file
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
        | "songs" ->
                printfn
                    " 
                    You may enter a song's name after the message 'Enter your music name' appears.

                    List of songs:
                    - GoldenWind            Play the original theme from Jojo's Bizare Adventures part 5
                    - Solvieg               Play 'Solvieg song' from Peer Gynt
                    - RR                    Play 'Rick Roll, Never Gonna Give You Up'
                    - Megalovania           Play the original theme from the game 'Undertale'
                    - Zelda                 Play the original theme from the game 'Zelda'
                    - Lac                   Play 'Les Lacs du Connemara' de 'Michel Sardou'
                    - Unravel               Play the original theme from 'Unravel'
                    - Kalinka               Play the traditional russian song 'Kalinka' from 'Ivan Larionov'
                    - TOM                   Play 'A-ha, Take On Me'
                    - LVER                  Play 'La Vie En Rose' from 'Edith Piaf'
                    - Amogus                Play 'Body discovered' sound from the game 'Among Us'
                    - Crazy                 Play 'CrazyFrog' from 'Alex F'
                    - Numb                  Play 'Numb' from 'Linkin Park'
                    - InTheEnd              Play 'In The End' from 'Linkin Park'
                    - LettreAElise          Play 'Lettre A Elise' from 'Bethoveen'


                    "
        | "Sus" ->
            Mogus |> ignore

            printfn
                "

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

⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣶⣿⣿⣷⣶⣄⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣾⣿⣿⡿⢿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⣿⡟⠁⣰⣿⣿⣿⡿⠿⠻⠿⣿⣿⣿⣿⣧⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⠏⠀⣴⣿⣿⣿⠉⠀⠀⠀⠀⠀⠈⢻⣿⣿⣇⠀⠀⠀
⠀⠀⠀⠀⢀⣠⣼⣿⣿⡏⠀⢠⣿⣿⣿⠇⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⡀⠀⠀
⠀⠀⠀⣰⣿⣿⣿⣿⣿⡇⠀⢸⣿⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⡇⠀⠀
⠀⠀⢰⣿⣿⡿⣿⣿⣿⡇⠀⠘⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⢀⣸⣿⣿⣿⠁⠀⠀
⠀⠀⣿⣿⣿⠁⣿⣿⣿⡇⠀⠀⠻⣿⣿⣿⣷⣶⣶⣶⣶⣶⣿⣿⣿⣿⠃⠀⠀⠀
⠀⢰⣿⣿⡇⠀⣿⣿⣿⠀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠀⠀⠀⠀
⠀⢸⣿⣿⡇⠀⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠉⠛⠛⠛⠉⢉⣿⣿⠀⠀⠀⠀⠀⠀
⠀⢸⣿⣿⣇⠀⣿⣿⣿⠀⠀⠀⠀⠀⢀⣤⣤⣤⡀⠀⠀⢸⣿⣿⣿⣷⣦⠀⠀⠀
⠀⠀⢻⣿⣿⣶⣿⣿⣿⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⣦⡀⠀⠉⠉⠻⣿⣿⡇⠀⠀
⠀⠀⠀⠛⠿⣿⣿⣿⣿⣷⣤⡀⠀⠀⠀⠀⠈⠹⣿⣿⣇⣀⠀⣠⣾⣿⣿⡇⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⣦⣤⣤⣤⣤⣾⣿⣿⣿⣿⣿⣿⣿⣿⡟⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⢿⣿⣿⣿⣿⣿⣿⠿⠋⠉⠛⠋⠉⠉⠁⠀⠀⠀⠀
            "
        | _ -> printfn "Unknown command, try typing 'help'" |> ignore


    [<EntryPoint>]
    let main argv =
        //args["F", "White", "5"]
        for arg in argv do
            match arg with
            | "start" -> 
                Console.Write("Welcome to Sound Synthesis, Please enter a command:")
                let message = Console.ReadLine()
                commands message |> ignore
                
                
            // | "Mogus" ->
            //     PlaySong(Amogus) |> ignore
            //     printfn "10"
            // | "PlayFile" ->
            //     Console.Write("Enter a valid path to your file: ")
            //     let url = Console.ReadLine()
            //     PlayURL url |> ignore
            //     printfn "15"
            // | "PlaySong" ->
            //     Console.Write("Enter your music name : ")
            //     let name = Console.ReadLine()
            //     PlaySong(searchMusic (name)) |> ignore
            //     printfn "16"
            // | "SaveFile" ->
            //     Console.Write("Enter your filename to save : ")
            //     let file = Console.ReadLine()

            //     let stream =
            //         File.Create($"./Audio/CreatedSounds/{file}.wav")

            //     CreateWavFile.write stream (SongAssemble(searchMusic (file)))
            //     |> ignore

            //     printfn "17"
            // | "SinWave" ->
            //     sinVisu "a" |> ignore
            //     printfn "a"
            // | "SqWave" ->
            //     SquareVisu "b" |> ignore
            //     printfn "b"
            // | "SawWave" ->
            //     sawVisu "c" |> ignore
            //     printfn "c"
            // | "TriangleWave" ->
            //     triVisu "d" |> ignore
            //     printfn "d"
            // | "ByFixedAMP" ->
            //     ampByFixedAmound "e" |> ignore
            //     printfn "e"
            // | "Overdrive" ->
            //     Overdrived "f" |> ignore
            //     printfn "f"
            // | "Envelope" ->
            //     Enveloped "g" |> ignore
            //     printfn "g"
            // | "Flange" ->
            //     Flanged "h" |> ignore
            //     printfn "h"
            // | "Chords" ->
            //     CombinedWaves "i" |> ignore
            //     printfn "i"
            // | "Echo" ->
            //     Echoed "j" |> ignore
            //     printfn "j"
            // | "Reverb" ->
            //     Reverbed "k" |> ignore
            //     printfn "k"
            // | "AM" ->
            //     AM "l" |> ignore
            //     printfn "l"
            // | "FM" ->
            //     FM "m" |> ignore
            //     printfn "m"
            // | "HighPass"
                // -> HighPass "n" |> ignore ; printfn "n"
            // | "LowPass"
                // -> LowPass "o" |> ignore ; printfn "o"
            // | "PlaySound"
            //     -> PlaySound |> ignore ; printfn "0"
            // | "CrazyFrog"
            //     -> PlaySong(Crazy) |> ignore ; printfn "1"
            // | "Gadjet"
            //     -> PlaySong(Gadjet) |> ignore ; printfn "3"
            // | "GoldenWind"
            //     ->  PlaySong(GoldenWind) |> ignore ; printfn "4"
            // | "InTheEnd"
            //     -> PlaySong(InTheEnd) |> ignore ; printfn "5"
            // | "Kalinka"
            //     -> PlaySong(Kalinka) |> ignore ; printfn "6"
            // | "Lac"
            //     -> PlaySong(Lac) |> ignore ; printfn "7"
            // | "LVER"
            //     -> PlaySong(LVER) |> ignore ; printfn "8"
            // | "Megalovania"
            //     -> PlaySong(Megalovania) |> ignore ; printfn "9"
            // | "Numb"
            //     -> PlaySong(Numb) |> ignore ; printfn "11"
            // | "RR"
            //     -> PlaySong(RR) |> ignore ; printfn "12"
            // | "Solvieg"
            //     -> PlaySong(Solvieg) |> ignore ; printfn "13"
            // | "TOM"
            //     -> PlaySong(TOM) |> ignore ; printfn "14"
            // | "Unravel"
            //     -> PlaySong(Unravel) |> ignore ; printfn "18"
            // | "ZeldaOverworld"
            //     -> PlaySong(ZeldaOverworld) |> ignore ; printfn "19"
            // | "LettreAElise"
            //     -> PlaySong(LettreAElise) |> ignore ; printfn "20"
            // | "help" ->
            //     printfn
            //         "
            //                 All the commands should start with 'dotnet run <commandName>'.

            //                 List of commands:
            //                 - help                  Show all the listed commands
            //                 - songs                 List all the songs you can play using 'dotnet run PlaySong'
            //                 - PlaySong              Play selected song from the 'Song's list
            //                 - PlayFile              Play a selected file
            //                 - SaveFile              Save file on the disk in './Audio/CreatedSounds/SavedSound.wav'
            //                 - SinWave               Visualise a SinWave using GoogleCharts
            //                 - SqWave                Visualise a SquareWave using GoogleCharts
            //                 - SawWave               Visualise a SawToothWave using GoogleCharts
            //                 - Sus                   He does seems really sus...
            //                 - TriangleWave          Visualise a TriangleWave using GoogleCharts
            //                 - ByFixedAmount         Visualise a SinWave using GoogleCharts with amplitude modified by a fixed amount
            //                 - Overdrive             Visualise an overdriven sound
            //                 - Envelope              Visualise a SinWave using GoogleCharts modified with an Envelope (ADSR)
            //                 - Flange                Visualise a Flanged sound
            //                 - Chords                Visualise two waves using GoogleCharts combined to get a Chords
            //                 - Echo                  Visualise a echoed sound
            //                 - Reverb                Visualise a reverbed sound
            //                 - AM                    Visualise a SinWave using GoogleCharts modified amplitude modulation
            //                 - FM                    Visualise a SinWave using GoogleCharts modified frequency modulation

            //                 "
            // | "songs" ->
            //     printfn
            //         "       Use the following commands after typing 'dotnet run PlaySong'.
            //                 You may enter a song's name after the message 'Enter your music name' appears.
                            
            //                 List of songs:
            //                 - GoldenWind            Play the original theme from Jojo's Bizare Adventures part 5
            //                 - Solvieg               Play 'Solvieg song' from Peer Gynt
            //                 - RR                    Play 'Rick Roll, Never Gonna Give You Up'
            //                 - Megalovania           Play the original theme from the game 'Undertale'
            //                 - Zelda                 Play the original theme from the game 'Zelda'
            //                 - Lac                   Play 'Les Lacs du Connemara' de 'Michel Sardou'
            //                 - Unravel               Play the original theme from 'Unravel'
            //                 - Kalinka               Play the traditional russian song 'Kalinka' from 'Ivan Larionov'
            //                 - TOM                   Play 'A-ha, Take On Me'
            //                 - LVER                  Play 'La Vie En Rose' from 'Edith Piaf'
            //                 - Amogus                Play 'Body discovered' sound from the game 'Among Us'
            //                 - Crazy                 Play 'CrazyFrog' from 'Alex F'
            //                 - Numb                  Play 'Numb' from 'Linkin Park'
            //                 - InTheEnd              Play 'In The End' from 'Linkin Park'
            //                 - LettreAElise          Play 'Lettre A Elise' from 'Bethoveen'


            //         "
            // | "Sus" ->
            //     Mogus |> ignore

            //     printfn
            //         "

            //                     ░█░█░█░█░█▀▀░█▀█
            //                     ░█▄█░█▀█░█▀▀░█░█
            //                     ░▀░▀░▀░▀░▀▀▀░▀░▀
            //                     ░▀█▀░█░█░█▀▀
            //                     ░░█░░█▀█░█▀▀
            //                     ░░▀░░▀░▀░▀▀▀
            //                     ░▀█▀░█▄█░█▀█░█▀█░█▀▀░▀█▀░█▀█░█▀▄
            //                     ░░█░░█░█░█▀▀░█░█░▀▀█░░█░░█░█░█▀▄
            //                     ░▀▀▀░▀░▀░▀░░░▀▀▀░▀▀▀░░▀░░▀▀▀░▀░▀
            //                     ░▀█▀░█▀▀
            //                     ░░█░░▀▀█
            //                     ░▀▀▀░▀▀▀
            //                     ░█▀▀░█░█░█▀▀
            //                     ░▀▀█░█░█░▀▀█
            //                     ░▀▀▀░▀▀▀░▀▀▀

            //                                 ⣠⣤⣤⣤⣤⣤⣶⣦⣤⣄⡀
            //                              ⢀⣴⣿⡿⠛⠉⠙⠛⠛⠛⠛⠻⢿⣿⣷⣤⡀
            //                              ⣼⣿⠋       ⢀⣀⣀⠈⢻⣿⣿⡄
            //                             ⣸⣿⡏   ⣠⣶⣾⣿⣿⣿⠿⠿⠿⢿⣿⣿⣿⣄
            //                             ⣿⣿⠁  ⢰⣿⣿⣯⠁       ⠈⠙⢿⣷⡄
            //                        ⣀⣤⣴⣶⣶⣿⡟   ⢸⣿⣿⣿⣆          ⣿⣷
            //                       ⢰⣿⡟⠋⠉⣹⣿⡇   ⠘⣿⣿⣿⣿⣷⣦⣤⣤⣤⣶⣶⣶⣶⣿⣿⣿
            //                       ⢸⣿⡇  ⣿⣿⡇    ⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃
            //                       ⣸⣿⡇  ⣿⣿⡇     ⠉⠻⠿⣿⣿⣿⣿⡿⠿⠿⠛⢻⣿⡇
            //                       ⣿⣿⠁  ⣿⣿⡇                ⢸⣿⣧
            //                       ⣿⣿   ⣿⣿⡇                ⢸⣿⣿
            //                       ⣿⣿   ⣿⣿⡇                ⢸⣿⣿
            //                       ⢿⣿⡆  ⣿⣿⡇                ⢸⣿⡇
            //                       ⠸⣿⣧⡀ ⣿⣿⡇                ⣿⣿⠃
            //                        ⠛⢿⣿⣿⣿⣿⣇     ⣰⣿⣿⣷⣶⣶⣶⣶⠶ ⢠⣿⣿
            //                             ⣿⣿     ⣿⣿⡇ ⣽⣿⡏⠁  ⢸⣿⡇
            //                             ⣿⣿     ⣿⣿⡇ ⢹⣿⡆   ⣸⣿⠇
            //                             ⢿⣿⣦⣄⣀⣠⣴⣿⣿⠁ ⠈⠻⣿⣿⣿⣿⡿⠏
            //                             ⠈⠛⠻⠿⠿⠿⠿⠋⠁
            //     "
            | _ -> printfn "Unknown command" |> ignore

        0
