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
    

    let rec commands (name : string) =
        match name with
        | "Mogus"-> 
            PlaySong(Amogus)
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore 
        | "PlayFile"-> 
                Console.Write("Enter a valid path to your file: ")
                let url = Console.ReadLine()
                PlayURL url 
                Console.Write("Please enter a command:")
                let message = Console.ReadLine()
                commands message |> ignore 
        | "PlaySong"-> 
                Console.Write("Enter your music name : ")
                let name = Console.ReadLine()
                PlaySong(searchMusic (name)) 
                Console.Write("Please enter a command:")
                let message = Console.ReadLine()
                commands message |> ignore 
        | "SaveFile"-> 
                Console.Write("Enter your filename to save : ")
                let file = Console.ReadLine()

                let stream =
                    File.Create($"./Audio/CreatedSounds/{file}.wav")

                CreateWavFile.write stream (SongAssemble(searchMusic (file)))
                Console.Write("Please enter a command:")
                let message = Console.ReadLine()
                commands message |> ignore 
                
        | "SinWave"-> 
            sinVisu()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore 
        | "SquareWave"-> 
            SquareVisu()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore 
        | "SawWave"->
            sawVisu()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore 
        | "TriangleWave"-> 
            triVisu()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "ByFixedAMP"-> 
            ampByFixedAmound()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "Overdrive"-> 
            Overdrived()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "Envelope"-> 
            Enveloped()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "Flange"-> 
            Flanged()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "Chords"-> 
            CombinedWaves()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "Echo"-> 
            Echoed()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "Reverb"-> 
            Reverbed()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "AM"-> 
            AM()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "FM"-> 
            FM()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "HighPass"-> 
            HighPass()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "LowPass" -> 
            LowPass()
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore   
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
                    - ByFixedAmount         Visualise a SinWave with amp modified by a fixed amount
                    - Overdrive             Visualise an overdriven sound
                    - Envelope              Visualise a SinWavew with an Envelope (ADSR)
                    - Flange                Visualise a Flanged sound
                    - Chords                Visualise two waves combined to get a Chords
                    - Echo                  Visualise a echoed sound
                    - Reverb                Visualise a reverbed sound
                    - AM                    Visualise a SinWave using with amplitude modulation
                    - FM                    Visualise a SinWave with frequency modulation

                    "
                Console.Write("Please enter a command:")
                let message = Console.ReadLine()
                commands message |> ignore
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
                Console.Write("Please enter a command:")
                let message = Console.ReadLine()
                commands message |> ignore
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
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore
        | "quit" ->  raise (System.Exception("You ended the session"))
        | _ -> 
            printfn "Unknown command, try typing 'help'" 
            Console.Write("Please enter a command:")
            let message = Console.ReadLine()
            commands message |> ignore


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
