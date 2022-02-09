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
        | "tetris" -> Tetris
        | "song" ->  
                printfn
                    " 
                    List of songs:
                    - goldenWind            Play the original theme from Jojo's Bizare Adventure
                    - solvieg               Play 'Solvieg song' from Peer Gynt
                    - tetris                   Play famous theme from the game Tetris
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
                    - tetris                   Play famous theme from Tetris 


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
                                        ⣾⣿⣿⠏ ⣴⣿⣿⣿⠉              ⠈⢻⣿⣿⣇   
                                ⢀⣠⣼⣿⣿⡏ ⢠⣿⣿⣿⠇                    ⠈⣿⣿⣿⡀  
                               ⣰⣿⣿⣿⣿⣿⡇ ⢸⣿⣿⣿⡀                        ⣿⣿⣿⡇  
                              ⢰⣿⣿⡿⣿⣿⣿⡇ ⠘⣿⣿⣿⣧                ⢀⣸⣿⣿⣿⠁  
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
        for arg in argv do
            match arg with
            | "start" -> 
                Console.Write("Welcome to Sound Synthesis, Please enter a command >")
                let message = Console.ReadLine()
                commands message |> ignore
            | _ -> printfn "Unknown command" |> ignore

        0
