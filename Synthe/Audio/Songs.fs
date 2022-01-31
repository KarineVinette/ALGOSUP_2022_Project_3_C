namespace SyntheAudio
open Note
open Waves

module Song =

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

    let Lac = [|
        G Black 5
        Sil Silence 0
        DDiese Black 5
        G Black 5
        Sil Silence 0
        DDiese Black 5
        G Black 5
        Sil Silence 0
        DDiese Black 5
        GDiese Black 5
        ADiese Black 5
        F Black 5
        G Black 5
        Sil Silence 0
        DDiese Black 5
        G Black 5
        Sil Silence 0
        DDiese Black 5
        G Black 5
        Sil Silence 0
        DDiese Black 5
        GDiese Black 5
        ADiese Black 5
        F Black 5
        G Black 5
        Sil Silence 0
        C Black 5
        DDiese Black 5
        Sil Silence 0
        C Black 5
        DDiese Black 5
        Sil Silence 0
        C Black 5
        DDiese Black 5
        D Black 5
        DDiese Black 5
        F PWhite 5
        GDiese White 5
        F Black 5
        GDiese White 5
        F Black 5
        GDiese White 5
        F Black 5
        ADiese Black 5
        GDiese Black 5
        G Black 5
        GDiese White 5
        F Black 5
        GDiese White 5
        F Black 5
        GDiese White 5
        F Black 5
        ADiese Black 5
        GDiese Black 5
        G Black 5
        GDiese White 5
        F Black 5
        GDiese White 5
        F Black 5
        GDiese White 5
        F Black 5
        GDiese Black 5
        G Black 5
        GDiese Black 5
        ADiese PWhite 5
        ADiese PWhite 5

        G Black 5
        DDiese HalfNote 5
        G Black 5
        DDiese HalfNote 5
        G Black 5
        DDiese HalfNote 5
        GDiese HalfNote 5
        G HalfNote 5
        F HalfNote 5
        G Black 5
        DDiese HalfNote 5
        G Black 5
        DDiese HalfNote 5
        G Black 5
        DDiese HalfNote 5
        GDiese HalfNote 5
        G HalfNote 5
        F HalfNote 5

    |]

    let Solvieg =[|
        E White 5
        C HalfNote 5
        E HalfNote 5
        A HalfNote 5
        B HalfNote 5
        B HalfNote 5
        A HalfNote 5
        G Round 5
        G White 5
        E HalfNote 5
        G HalfNote 5
        C HalfNote 6
        D HalfNote 6
        B Black 5
        E White 6
        E HalfNote 6
        HalfSil HalfSilence 0 
        B Black 4
        E White 5
        E HalfNote 5
        Sil Silence 0
        MSil MSilence 0
        |]

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
        Sil Silence 0 
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
        Sil Silence 0 
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
        
    //beginning of Unravel song 
    let Unravel = [|
        ADiese HalfNote 5;
        C Black 6;
        ADiese Black 5;
        A HalfNote 5;
        G Black 5;
        C Black 6;
        ADiese Black 5;
        |]

    let LVER = [|
        D PBlack 6
        CDiese HalfNote 6
        B PHalfNote 5
        A QuarterNote 5
        FDiese PHalfNote 5
        D QuarterNote 6
        CDiese PBlack 6
        B HalfNote 5
        A PHalfNote 5
        FDiese QuarterNote 5
        D PHalfNote 5
        CDiese QuarterNote 6
        B Black 5
        A Black 5
        B Black 5
        CDiese Black 6
        D Black 6
        B Black 5
        A HalfNote 5
        FDiese HalfNote 5
        FDiese HalfNote 5
        E HalfNote 5
        D HalfNote 5
        CDiese HalfNote 5
        D HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        G HalfNote 5
        G HalfNote 5
        FDiese HalfNote 5
        E HalfNote 5
        DDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        G HalfNote 5
        A HalfNote 5
        A HalfNote 5
        G HalfNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        G HalfNote 5
        A HalfNote 5
        A HalfNote 5
        A HalfNote 5
        A HalfNote 5
        A HalfNote 5
        A HalfNote 5
        FDiese HalfNote 5
        GDiese HalfNote 5
        A White 5
        D PBlack 6
        CDiese HalfNote 6
        B PHalfNote 5
        A QuarterNote 5
        FDiese PHalfNote 5
        D QuarterNote 6
        CDiese PBlack 6
        B HalfNote 5
        A PHalfNote 5
        FDiese QuarterNote 5
        D PHalfNote 5
        CDiese QuarterNote 6
        B PBlack 5
        A HalfNote 5
        FDiese PHalfNote 5
        CDiese QuarterNote 5
        D PHalfNote 5
        CDiese QuarterNote 6
        B White 5
        A White 5
        |]

    let Kalinka = [|
        E Black 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 5;
        D Black 6;
        C HalfNote 6;
        B HalfNote 5;
        A Black 5;
        E HalfNote 6;
        E QuarterNote 6;
        E QuarterNote 6;
        D PHalfNote 6;
        C QuarterNote 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        C HalfNote 6;
        B HalfNote 5;
        A Black 5;
        E HalfNote 6;
        E HalfNote 6;

        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        C HalfNote 6;
        B HalfNote 5;
        A Black 5;
        E HalfNote 6;
        E QuarterNote 6;
        E QuarterNote 6;
        D HalfNote 6;
        C HalfNote 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        C HalfNote 6;
        B HalfNote 5;
        A Black 5;
        Sil Silence 0; 
        E HalfNote 6;
        G HalfNote 6;
        F HalfNote 6;
        E QuarterNote 6;
        D QuarterNote 6;

        C Black 6;
        G Black 5;
        E HalfNote 6;
        G HalfNote 6;
        F HalfNote 6;
        E QuarterNote 6;
        D QuarterNote 6;
        C Black 6;
        G Black 5;
        A Black 5;
        A HalfNote 5;
        B HalfNote 5;
        D HalfNote 6;
        C HalfNote 6;
        B HalfNote 5;
        A HalfNote 5;
        G Black 5;
        G Black 5;
        G White 5;
        E HalfNote 6;
        G HalfNote 5;
        F HalfNote 6;
        E QuarterNote 6;
        D QuarterNote 6;
        C Black 6;
        G Black 5;
        E HalfNote 6;
        G HalfNote 6;
        F HalfNote 6;
        E QuarterNote 6;
        D QuarterNote 6;

        C Black 6;
        G Black 6;
        A Black 5;
        A HalfNote 5;
        B HalfNote 5;
        D HalfNote 6;
        C HalfNote 6;
        B HalfNote 5;
        A HalfNote 5;
        G Black 6;
        F Black 6;
        E Black 6;
        E Black 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        C HalfNote 6;
        B HalfNote 5;
        A Black 5;
        E HalfNote 6;
        E QuarterNote 6;
        E QuarterNote 6;
        D PHalfNote 6;
        C QuarterNote 6;
        B HalfNote 5;
        C HalfNote 6;

        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        C HalfNote 6;
        B HalfNote 5;
        A Black 5;
        E HalfNote 6;
        E HalfNote 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        C HalfNote 6;
        B HalfNote 5;
        A Black 5;
        E HalfNote 6;
        E QuarterNote 6;
        E QuarterNote 6;
        D PHalfNote 6;
        C QuarterNote 6;
        B HalfNote 5;
        C HalfNote 6;
        D Black 6;
        B HalfNote 5;
        C HalfNote 6;
        |]

    let RR =[|  // A finir
        F PBlack 4
        G PBlack 4
        C Black 4
        G PBlack 4
        A PBlack 4
        C Triolet 5
        ADiese Triolet 4
        A Triolet 4
        F PBlack 4
        G PBlack 4 
        C White 4
        Sil Silence 4
        C HalfNote 4
        C HalfNote 4
        D QuarterNote 4
        E HalfNote 4
        F QuarterNote 4
        F PBlack 4
        G PBlack 4
        C Black 4
        G PBlack 4
        A PBlack 4
        C Triolet 5
        ADiese Triolet 4
        A Triolet 4
        F PBlack 4
        G PBlack 4 
        C Black 4
        E HalfNote 4
        F HalfNote 4
        F Black 4
        Sil Silence 4
        F QuarterNote 4
        F HalfNote 4 
        F QuarterNote 4

    |]

    let Megalovania = [|  // A Finir
        D QuarterNote 4
        D QuarterNote 4 
        D HalfNote 5
        A HalfNote 4
        QSilence QuarterSilence 4
        GDiese QuarterNote 4
        QSilence QuarterSilence 4
        G QuarterNote 4
        QSilence QuarterSilence 4
        F HalfNote 4
        D QuarterNote 4
        F QuarterNote 4
        G QuarterNote 4

        C QuarterNote 4
        C QuarterNote 4 
        D HalfNote 5
        A HalfNote 4
        QSilence QuarterSilence 4
        GDiese QuarterNote 4
        QSilence QuarterSilence 4
        G QuarterNote 4
        QSilence QuarterSilence 4
        F HalfNote 4
        D QuarterNote 4
        F QuarterNote 4
        G QuarterNote 4

        B QuarterNote 3
        ADiese QuarterNote 3 
        D HalfNote 5
        A HalfNote 4
        QSilence QuarterSilence 4
        GDiese QuarterNote 4
        QSilence QuarterSilence 4
        G QuarterNote 4
        QSilence QuarterSilence 4
        F HalfNote 4
        D QuarterNote 4
        F QuarterNote 4
        G QuarterNote 4

        ADiese QuarterNote 3
        ADiese QuarterNote 3 
        D HalfNote 5
        A HalfNote 4
        QSilence QuarterSilence 4
        GDiese QuarterNote 4
        QSilence QuarterSilence 4
        G QuarterNote 4
        QSilence QuarterSilence 4
        F HalfNote 4
        D QuarterNote 4
        F QuarterNote 4
        G QuarterNote 4
    |]

    let TOM = [|
        FDiese HalfNote 5
        FDiese HalfNote 5
        E HalfNote 5
        B HalfNote 4
        HalfSil HalfSilence 0
        B HalfNote 4
        HalfSil HalfSilence 0
        E HalfNote 5
        HalfSil HalfSilence 0
        E HalfNote 5
        HalfSil HalfSilence 0
        E HalfNote 5
        GDiese HalfNote 5        
        GDiese HalfNote 5
        A HalfNote 5
        CDiese HalfNote 6
        A HalfNote 5        
        A HalfNote 5        
        A HalfNote 5
        E HalfNote 5
        HalfSil HalfSilence 0
        D HalfNote 5
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        E HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        E HalfNote 5
        //repeat
        FDiese HalfNote 5
        FDiese HalfNote 5
        E HalfNote 5
        B HalfNote 4
        HalfSil HalfSilence 0
        B HalfNote 4
        HalfSil HalfSilence 0
        E HalfNote 5
        HalfSil HalfSilence 0
        E HalfNote 5
        HalfSil HalfSilence 0
        E HalfNote 5
        GDiese HalfNote 5        
        GDiese HalfNote 5
        A HalfNote 5
        CDiese HalfNote 6
        A HalfNote 5        
        A HalfNote 5        
        A HalfNote 5
        E HalfNote 5
        HalfSil HalfSilence 0
        D HalfNote 5
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        E HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        E HalfNote 5
        //refrain
        D PBlack 5
        D HalfNote 5
        D HalfNote 5
        CDiese HalfNote 5
        B Black 4
        MSil MSilence 0
        CDiese HalfNote 5
        CDiese Black 5
        CDiese HalfNote 5
        CDiese HalfNote 5
        A HalfNote 4
        Sil Silence 0
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        FDiese Black 5
        E Black 5
        D PBlack 5
        D HalfNote 5
        D HalfNote 5
        CDiese Black 5
        B HalfNote 4
        B Black 4
        Sil Silence 0
        Sil Silence 0
        HalfSil HalfSilence 0
        E HalfNote 4
        CDiese Black 5
        CDiese HalfNote 5
        CDiese HalfNote 5
        CDiese HalfNote 5
        B HalfNote 4
        A HalfNote 4
        A HalfNote 4
        A HalfNote 4
        B HalfNote 4
        CDiese HalfNote 5
        B QuarterNote 4
        CDiese QuarterNote 5
        B HalfNote 4
        A Black 4
        Sil Silence 0
        D Black 5
        D Black 5
        D HalfNote 5
        E HalfNote 5
        E Black 5
        Sil Silence 0
        MSil MSilence 0
        Sil Silence 0
        FDiese HalfNote 4
        A HalfNote 4
        A HalfNote 4
        A HalfNote 4
        A HalfNote 4
        A HalfNote 4
        A HalfNote 4
        GDiese PBlack 4
        GDiese HalfNote 4
        FDiese PBlack 4
        A Round 4
        GDiese Round 4
        A Round 4
        E Black 5
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        FDiese Black 5
        E Black 5
        A Round 4
        E Round 5
        FDiese Round 5
        E Black 5
        HalfSil HalfSilence 0
        FDiese HalfNote 5
        FDiese Black 5
        E Black 5
        |]

    let ZeldaOverworld = [|
        A White 5
        A Triolet 5
        A Triolet 5
        A Triolet 5
        A Triolet 5
        A HalfNote 5
        G Triolet 5
        A Black 5
        TrSilence TrioletSilence 5
        TrSilence TrioletSilence 5
        A Triolet 5
        A Triolet 5
        A Triolet 5
        A Triolet 5
        A HalfNote 5
        G Triolet 5
        A Black 5
        TrSilence TrioletSilence 5
        TrSilence TrioletSilence 5
        A Triolet 5
        A Triolet 5
        A Triolet 5
        A Triolet 5
        A HalfNote 5
        E QuarterNote 5
        E QuarterNote 5
        E HalfNote 5
        E QuarterNote 5
        E QuarterNote 5
        E HalfNote 5
        E QuarterNote 5
        E QuarterNote 5
        E HalfNote 5
        E HalfNote 5



    |]

    let test (song: byte [][] ) =  // The most unbelievable thing to play a song
            let mutable wave2 = sinbyte 1. 0.
            for j in 0..song.Length-1 do
                let delay = Array.init (int(sampleRate/1000.)) (fun i -> 0. |> sample)
                wave2 <- Array.concat[|wave2; delay; song.[j]|]
            wave2
