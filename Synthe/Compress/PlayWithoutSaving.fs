//namespace CreateSound 
    module createSound 
        open Waves
        open System.IO
        open SFML.Audio
        open System.Threading

        let fusedData wave =
            wave |> Array.concat

        let write stream (data:byte[]) =
            let writer = new BinaryWriter(stream)
            // RIFF
            writer.Write("RIFF"B)
            let size = 36 + data.Length in writer.Write(size)
            writer.Write("WAVE"B)
            // fmt
            writer.Write("fmt "B)
            let headerSize = 16 in writer.Write(headerSize)
            let pcmFormat = 1s in writer.Write(pcmFormat)
            let mono = 1s in writer.Write(mono)
            let sampleRate = 44100 in writer.Write(sampleRate) 
            let byteRate = sampleRate in writer.Write(byteRate)
            let blockAlign = 1s in writer.Write(blockAlign)
            let bitsPerSample = 8s in writer.Write(bitsPerSample)
            // data
            writer.Write("data"B)
            writer.Write(data.Length)
            writer.Write(data)

        let sample x = (x + 1.)/2. * 255. |> byte 

        let data1 = sinbyte
        let data2 = squarebyte
        let data3 = fusedData [|data1;data2|]  

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
        write convert data3

        p.play(convert)