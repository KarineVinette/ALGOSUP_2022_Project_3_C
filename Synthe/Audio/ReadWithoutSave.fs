namespace SyntheAudio
open System.Threading
open SFML.Audio
open SFML.System
open System.IO
open Song
open SyntheCompress

module Play = 
        type PlaySound()=
                member x.play stream =
                        let buffer = new SoundBuffer(stream:Stream)
                        let sound = new Sound(buffer)
                        sound.Play()

                        do while sound.Status = SoundStatus.Playing do 
                                Thread.Sleep(1)

        
        let PlayURL (url:string) = //Allow to choose your file
                let buffer = new SoundBuffer(url) //Storage for audio sample defining a sound
                let sound = new Sound(buffer) 
                sound.Play() 

                while sound.Status = SoundStatus.Playing do
                Thread.Sleep(100)


        let PlaySong (song:byte[][]) =
                let sample x = (x + 1.)/2. * 255. |> byte
                let data = SongAssemble song

                        
                let p = new PlaySound()

                        // convert is used to convert data's bytes in stream

                let convert = new MemoryStream()
                createSound.write convert data

                p.play(convert)
                

        // Read a section of an audio file from disk with a Offset (number of seconds before it starts)
        let PlayWithOffsetFromPath (offset) (filePath:string) =
                let stream = File.Open (filePath, FileMode.Open)
                let music = new Music(stream)
                let timeOffset = Time.FromSeconds(float32(offset))
                music.PlayingOffset <- timeOffset
                music.Play()

                while music.Status = SoundStatus.Playing do
                      Thread.Sleep(100)
