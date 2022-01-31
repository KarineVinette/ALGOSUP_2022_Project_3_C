module Song

    open Waves
    open Note
    open BasicFilters

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

    // let Solvieg =[|
    //     E White 5
    //     C HalfNote 5
    //     E HalfNote 5
    //     A HalfNote 5
    //     B HalfNote 5
    //     B HalfNote 5
    //     A HalfNote 5
    //     G Round 5
    //     G White 5
    //     E HalfNote 5
    //     G HalfNote 5
    //     C HalfNote 6
    //     D HalfNote 6
    //     B Black 5
    //     E White 6
    //     E HalfNote 6
    //     HalfSil HalfSilence 0 
    //     B Black 4
    //     E White 5
    //     E HalfNote 5
    //     Sil Silence 0
    //     MSil MSilence 0
    //     |]

    let Gadjet = [|
        G QuarterNote 5
        ADiese QuarterNote 5
        B QuarterNote 5
        CDiese QuarterNote 6
        DDiese HalfNote 6
        B HalfNote 5
        D HalfNote 6
        ADiese HalfNote 5
        CDiese HalfNote 6
        B HalfNote 5
        G QuarterNote 5
        ADiese QuarterNote 5
        B QuarterNote 5
        CDiese QuarterNote 6
        DDiese HalfNote 6
        GDiese HalfNote 6
        G White 6
        Silence HalfNote 
        E QuarterNote 6
        B QuarterNote 5
        B QuarterNote 5
        B QuarterNote 5
        E HalfNote 6
        B HalfNote 5
        D HalfNote 6
        ADiese HalfNote 5
        CDiese HalfNote 6
        B HalfNote 5
        Silence Round 
        G QuarterNote 5
        ADiese QuarterNote 5
        B QuarterNote 5
        CDiese QuarterNote 6
        DDiese HalfNote 6
        B HalfNote 5
        D HalfNote 6
        ADiese HalfNote 5
        CDiese HalfNote 6
        B HalfNote 5
        G QuarterNote 5
        ADiese QuarterNote 5
        B QuarterNote 5
        CDiese QuarterNote 6
        DDiese HalfNote 6
        G HalfNote 6
        G White 6
        MSil Round 0 
        |]
        
    // beginning of Unravel song 
    let Unravel = [|
        ADiese HalfNote 5;
        C Black 6;
        ADiese Black 5;
        A HalfNote 5;
        G Black 5;
        C Black 6;
        ADiese Black 5;
        |]

    let LaVieEnRose = [|
        GDiese PWhite 4;
        G PHalfNote 4;
        F PHalfNote 4;
        HalfSil HalfSilence 0;
        DDiese PHalfNote 4;
        C PHalfNote 4;
        HalfSil HalfSilence 0;
        GDiese PHalfNote 4;
        G PWhite 4;
        Sil Silence 0;
        F PHalfNote 4;
        DDiese PHalfNote 4;
        HalfSil HalfSilence 0;
        C PHalfNote 4;
        GDiese PHalfNote 3;
        HalfSil HalfSilence 0;
        G PHalfNote 4;
        F PWhite 4;
        Sil Silence 4;
        DDiese PHalfNote 4;
        C PHalfNote 4;
        HalfSil HalfSilence 0;
        G PHalfNote 3;
        GDiese PHalfNote 3;
        HalfSil HalfSilence 0;
        G PHalfNote 4;
        F PWhite 4;
        DDiese PBlack 4;
        |]

    let test (song: byte [][] ) =  // The most unbelievable thing to play a song
            let mutable wave2 = sinbyte 1. 0.
            for j in 0..song.Length-1 do
                let delay = Array.init (int(sampleRate/1000.)) (fun i -> 0. |> sample)
                wave2 <- Array.concat[|wave2; delay; song.[j]|]
            wave2