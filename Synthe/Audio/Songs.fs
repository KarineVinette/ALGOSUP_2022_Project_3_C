namespace SyntheAudio
open Note

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
        HalfSil HalfSilence 0
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
        MSil MSilence 0
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
        MSil MSilence 0 
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
        GDiese White 4;
        GDiese Black 4;
        G Black 4;
        F PBlack 4;
        DDiese Black 4;
        C PBlack 4;
        GDiese Black 4;
        G PBlack 4;
        G PBlack 4;
        F Black 4;
        DDiese PBlack 4;
        C Black 4;
        GDiese PBlack 3;
        G Black 4;
        F PBlack 4;
        F PBlack 4;
        DDiese Black 4;
        C Black 4;
        G Black 3;
        GDiese Black 3;
        G Black 4;
        F Round 4;
        DDiese White 4;
        |]

    let test (song: byte [][] ) =  // The most unbelievable thing to play a song
                let mutable wave2 = Waves.sinbyte 1. 0.
                for j in 0..song.Length-1 do
                    let delay = Array.init (int(Waves.sampleRate/100.)) (fun i -> 0. |> Waves.sample)
                    wave2 <- Array.concat[|wave2; delay; song.[j]|]
                wave2