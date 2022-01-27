module Song

    open Waves
    open Note

    let GoldenWind =[|
        FDiese Black 5; 
        F White 5;
        D HalfNote 5;
        E HalfNote 5;
        F Black 5;
        E HalfNote 5;
        D HalfNote 5;
        CDiese HalfNote 5;
        D Black 5;
        E Black 5;
        FDiese White 5;
        B White 5;
        B HalfNote 4;
        CDiese HalfNote 5;
        D Black 5;
        E HalfNote 5;
        D HalfNote 5;
        CDiese HalfNote 5;
        A Black 5;
        G Black 5;
        FDiese Black 5; 
        F White 5;
        D HalfNote 5;
        E HalfNote 5;
        F HalfNote 5;
        E Black 5;
        D HalfNote 5;
        CDiese HalfNote 5;
        D HalfNote 5;
        E Black 5;
        FDiese Black 5;
        B White 5;
        B HalfNote 5;
        CDiese HalfNote 6;
        D HalfNote 6;
        G Black 5;
        FDiese HalfNote 5;
        F HalfNote 5;
        D Black 6;
        ADiese HalfNote 5;
        B White 5;
        |]

    let test (song:byte [][] ) =  // The most unbelievable thing to play a song
            let mutable wave2 = sinbyte 1 0.
            for j in 0..song.Length-1 do
                let delay = Array.init (int(sampleRate/100.)) (fun i -> 0. |> sample)
                wave2 <- Array.concat[|wave2; delay; song.[j]|]
            wave2