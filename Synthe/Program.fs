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
    let rec searchMusic (name: string) =
        match name with
        | "goldenWind" -> GoldenWind
        | "inTheEnd" -> InTheEnd
        | "lac" -> Lac
        | "solvieg" -> Solvieg
        | "gadjet" -> Gadjet
        | "unravel" -> Unravel
        | "LVER" -> LVER
        | "kalinka" -> Kalinka
        | "RR" -> RR
        | "sus" -> Amogus
        | "megalovania" -> Megalovania
        | "TOM" -> TOM
        | "zeldaOverworld" -> ZeldaOverworld
        | "crazy" -> Crazy
        | "envelope" -> testenvelope
        | "reverb" -> SoundReverbed
        | "song" ->  
                printfn
                    " 
                    List of songs:
                    - goldenWind            Play the original theme from Jojo's Bizare Adventure
                    - solvieg               Play 'Solvieg song' from Peer Gynt
                    - RR                    Play 'Rick Roll, Never Gonna Give You Up'
                    - megalovania           Play the original theme from the game 'Undertale'
                    - zelda                 Play the original theme from the game 'Zelda'
                    - lac                   Play 'Les Lacs du Connemara' de 'Michel Sardou'
                    - unravel               Play the original theme from 'Unravel'
                    - kalinka               Play the traditional russian song 'Kalinka'
                    - TOM                   Play 'A-ha, Take On Me'
                    - LVER                  Play 'La Vie En Rose' from 'Edith Piaf'
                    - amogus                Play 'Body discovered' sound from the game 'Among Us'
                    - crazy                 Play 'CrazyFrog' from 'Alex F'
                    - numb                  Play 'Numb' from 'Linkin Park'
                    - inTheEnd              Play 'In The End' from 'Linkin Park'
                    - lettreAElise          Play 'Lettre A Elise' from 'Bethoveen'
                    - overdrive             Play a note overdrived
                    - flange                Play a note flanged
                    - reverb                Play a note reverbed
                    - echo                  Play a note echoed


                    "
                Console.Write("Please enter a song >")
                let message = Console.ReadLine()
                searchMusic message 
        | _ -> 
                printfn "Unknown song, try typing 'song'" 
                Console.Write("Please enter a song >")
                let message = Console.ReadLine()
                searchMusic message
    

    let rec commands (name : string) =
        match name with
        | "mogus"-> 
            PlaySong(Amogus)
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore 
        | "playFile"-> 
                Console.Write("Enter a valid path to your file: ")
                let url = Console.ReadLine()
                PlayURL url 
                Console.Write("Please enter a command >")
                let message = Console.ReadLine()
                commands message |> ignore 
        | "playSong"-> 
                Console.Write("Enter your music name : ")
                let name = Console.ReadLine()
                PlaySong(searchMusic (name)) 
                Console.Write("Please enter a command >")
                let message = Console.ReadLine()
                commands message |> ignore 
        | "saveFile"-> 
                Console.Write("Enter your filename to save : ")
                let file = Console.ReadLine()

                let stream =
                    File.Create($"./Audio/CreatedSounds/{file}.wav")

                createSound.write stream (SongAssemble(searchMusic (file)))
                Console.Write("Please enter a command >")
                let message = Console.ReadLine()
                commands message |> ignore 
        | "readSection" ->
                Console.WriteLine("Enter the path of the file : ") 
                let path = Console.ReadLine()
                Console.WriteLine("From how many seconds you want to play the file ?")   
                let s = Convert.ToInt32(Console.ReadLine())
                PlayWithOffsetFromPath s path 

        | "sinWave"-> 
            sinVisu()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore 
        | "squareWave"-> 
            SquareVisu()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore 
        | "sawWave"->
            sawVisu()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore 
        | "triangleWave"-> 
            triVisu()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "byFixedAMP"-> 
            ampByFixedAmound()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "overdrive"-> 
            Overdrived()
            //PlaySong(SoundOverdrived)
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "envelope"-> 
            Enveloped()
            PlaySong(testenvelope)
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "flange"-> 
            Flanged()
            //PlaySong(SoundFlanged)
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "chords"-> 
            CombinedWaves()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "echo"-> 
            Echoed()
            // PlaySong(SoundEchoed)
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "reverb"-> 
            Reverbed()
            PlaySong(SoundReverbed)
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "AM"-> 
            AM()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "FM"-> 
            FM()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "highPass"-> 
            HighPass()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "lowPass" -> 
            LowPass()
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore   
        | "help" ->
                printfn
                    "
                    List of commands:
                    - help                  Show all the listed commands
                    - songs                 List all the songs you can play using 'dotnet run PlaySong'
                    - playSong              Play selected song from the 'Song's list
                    - playFile              Play a selected file
                    - saveFile              Save file on the disk in './Audio/CreatedSounds/SavedSound.wav'
                    - readSection           Read a section of an audio file from disk
                    - sinWave               Visualise a SinWave using GoogleCharts
                    - squareWave            Visualise a SquareWave using GoogleCharts
                    - sawWave               Visualise a SawToothWave using GoogleCharts
                    - sus                   He does seems really sus...
                    - triangleWave          Visualise a TriangleWave using GoogleCharts
                    - byFixedAmount         Visualise a SinWave with amp modified by a fixed amount
                    - overdrive             Visualise an overdriven sound
                    - envelope              Visualise a SinWavew with an Envelope (ADSR)    
                    - flange                Visualise a Flanged sound
                    - chords                Visualise two waves combined to get a Chords
                    - echo                  Visualise a echoed sound
                    - reverb                Visualise a reverbed sound
                    - AM                    Visualise a SinWave using with amplitude modulation
                    - FM                    Visualise a SinWave with frequency modulation
                    - lowPass             Visualise Low Pass filter 
                    - highPass            Visualise High Pass filter 

                    "
                Console.Write("Please enter a command >")
                let message = Console.ReadLine()
                commands message |> ignore
        | "songs" ->
                printfn
                    " 
                    You may enter a song's name after the message 'Enter your music name' appears.

                    List of songs:
                    - goldenWind            Play the original theme from Jojo's Bizare Adventures part 5
                    - solvieg               Play 'Solvieg song' from Peer Gynt
                    - RR                    Play 'Rick Roll, Never Gonna Give You Up'
                    - megalovania           Play the original theme from the game 'Undertale'
                    - zelda                 Play the original theme from the game 'Zelda'
                    - lac                   Play 'Les Lacs du Connemara' de 'Michel Sardou'
                    - unravel               Play the original theme from 'Unravel'
                    - kalinka               Play the traditional russian song 'Kalinka' from 'Ivan Larionov'
                    - TOM                   Play 'A-ha, Take On Me'
                    - LVER                  Play 'La Vie En Rose' from 'Edith Piaf'
                    - amogus                Play 'Body discovered' sound from the game 'Among Us'
                    - crazy                 Play 'CrazyFrog' from 'Alex F'
                    - numb                  Play 'Numb' from 'Linkin Park'
                    - inTheEnd              Play 'In The End' from 'Linkin Park'
                    - lettreAElise          Play 'Lettre A Elise' from 'Bethoveen'


                    "
                Console.Write("Please enter a command >")
                let message = Console.ReadLine()
                commands message |> ignore
        | "sus" ->
            PlaySong(Amogus) |> ignore

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

                                      ⣠⣴⣶⣿⣿⣷⣶⣄⣀⣀         
                                     ⣰⣾⣿⣿⡿⢿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀     
                                   ⢀⣾⣿⣿⡟⠁⣰⣿⣿⣿⡿⠿⠻⠿⣿⣿⣿⣿⣧    
                                   ⣾⣿⣿⠏ ⣴⣿⣿⣿⠉     ⠈⢻⣿⣿⣇   
                                ⢀⣠⣼⣿⣿⡏ ⢠⣿⣿⣿⠇       ⠈⣿⣿⣿⡀  
                               ⣰⣿⣿⣿⣿⣿⡇ ⢸⣿⣿⣿⡀        ⣿⣿⣿⡇  
                              ⢰⣿⣿⡿⣿⣿⣿⡇ ⠘⣿⣿⣿⣧      ⢀⣸⣿⣿⣿⠁  
                              ⣿⣿⣿⠁⣿⣿⣿⡇  ⠻⣿⣿⣿⣷⣶⣶⣶⣶⣶⣿⣿⣿⣿⠃   
                             ⢰⣿⣿⡇ ⣿⣿⣿    ⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁    
                             ⢸⣿⣿⡇ ⣿⣿⣿       ⠉⠛⠛⠛⠉⢉⣿⣿      
                             ⢸⣿⣿⣇ ⣿⣿⣿     ⢀⣤⣤⣤⡀  ⢸⣿⣿⣿⣷⣦   
                              ⢻⣿⣿⣶⣿⣿⣿     ⠈⠻⣿⣿⣿⣦⡀ ⠉⠉⠻⣿⣿⡇  
                               ⠛⠿⣿⣿⣿⣿⣷⣤⡀    ⠈⠹⣿⣿⣇⣀ ⣠⣾⣿⣿⡇  
                                   ⠹⣿⣿⣿⣿⣦⣤⣤⣤⣤⣾⣿⣿⣿⣿⣿⣿⣿⣿⡟   
                                     ⠉⠻⢿⣿⣿⣿⣿⣿⣿⠿⠋⠉⠛⠋⠉⠉⠁    
            "
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore
        | "quit" ->  raise (System.Exception("You ended the session"))
        | _ -> 
            printfn "Unknown command, try typing 'help'" 
            Console.Write("Please enter a command >")
            let message = Console.ReadLine()
            commands message |> ignore


    [<EntryPoint>]
    let main argv =
        //args["F", "White", "5"]
        for arg in argv do
            match arg with
            | "start" -> 
                Console.Write("Welcome to Sound Synthesis, Please enter a command >")
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
