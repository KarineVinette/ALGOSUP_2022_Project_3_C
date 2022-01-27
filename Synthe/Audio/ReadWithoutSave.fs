module lecture 
        open System
        open System.Threading
        open SFML.Audio
        open System.IO
        open creation
        open Waves
        open BasicFilters
        open Song

        let sample x = (x + 1.)/2. * 255. |> byte
        let data = test GoldenWind

        type PlaySound()=
                        member x.play stream =
                                let buffer = new SoundBuffer(stream:Stream)
                                let sound = new Sound(buffer)
                                sound.Play()
                
                                do while sound.Status = SoundStatus.Playing do 
                                        Thread.Sleep(1)
                
        let p = new PlaySound()

                // convert is used to convert data's bytes in stream
        
        let convert = new MemoryStream()
        write convert data

        p.play(convert)