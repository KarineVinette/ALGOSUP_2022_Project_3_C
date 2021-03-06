namespace SyntheAudio
open Note
open Waves
open Effect

module Song =

    let Tetris = [| //tempo 140
        addWaves(B Black 4)(E Black 5)

        E Black 5
        addWaves(GDiese HalfNote 4)(B HalfNote 4)
        C HalfNote 5
        D HalfNote 5
        E QuarterNote 5
        D QuarterNote 5
        addWaves(A HalfNote 4)(C HalfNote 5)
        addWaves(G HalfNote 4)(B HalfNote 4)

        addWaves(E Black 4)(A Black 4)
        A HalfNote 4
        C HalfNote 5
        E Black 5
        D HalfNote 5
        C HalfNote 5

        addWaves(GDiese Black 4)(B Black 4)
        addWaves(G HalfNote 4)(B HalfNote 4)
        addWaves(A HalfNote 4)(C HalfNote 5)
        addWaves(B Black 4)(D Black 5)
        E Black 5

        C Black 5
        A  Black 4
        A  Black 4
        Sil Silence 0

        HalfSil HalfSilence 0
        addWaves(F Black 4)(D Black 5)
        addWaves(A  HalfNote 4)(F  HalfNote 5)
        addWaves(C Black 5)(A Black 5)
        addWaves(B HalfNote 4)(G HalfNote 5)
        addWaves(A HalfNote 4)(F HalfNote 5)

        addWaves(G PBlack 4)(E PBlack 5)
        addWaves(E HalfNote 4)(C HalfNote 5)
        addWaves(G Black 4)(E Black 5)
        addWaves(F HalfNote 4)(D HalfNote 5)
        addWaves(E HalfNote 4)(C HalfNote 5)

        addWaves(GDiese Black 4)(B Black 4)
        addWaves(C HalfNote 4)(B HalfNote 4)
        addWaves(A HalfNote 4)(C HalfNote 5)
        addWaves(B Black 4)(D Black 5)
        E Black 5

        C Black 5
        A Black 4
        A Black 4
        Sil Silence 0
        // optional part
        E Black 5
        addWaves(GDiese HalfNote 4)(B HalfNote 4)
        C HalfNote 5
        D Black 5
        addWaves(A HalfNote 4)(C HalfNote 5)
        addWaves(G HalfNote 4)(B HalfNote 4)

        addWaves(E Black 4)(A Black 4)
        A HalfNote 4
        C HalfNote 5
        E Black 5
        D HalfNote 5
        C HalfNote 5

        addWaves(GDiese Black 4)(B Black 4)
        addWaves(G HalfNote 4)(B HalfNote 4)
        addWaves(A HalfNote 4)(C HalfNote 5)
        addWaves(B Black 4)(D Black 5)
        E Black 5

        C Black 5
        A Black 4
        A Black 4
        Sil Silence 0

        HalfSil HalfSilence 0
        addWaves(F Black 4)(D Black 5)
        addWaves(A HalfNote 4)(F HalfNote 5)
        addWaves(C Black 5)(A Black 5)
        addWaves(B HalfNote 4)(G HalfNote 5)
        addWaves(A HalfNote 4)(F HalfNote 5)

        addWaves(G PBlack 4)(E PBlack 5)
        addWaves(E HalfNote 4)(C HalfNote 4)
        addWaves(G Black 4)(E Black 5)
        addWaves(F HalfNote 4)(D HalfNote 5)
        addWaves(E HalfNote 4)(C HalfNote 5)

        addWaves(GDiese Black 4)(B Black 4)
        addWaves(G HalfNote 4)(B HalfNote 4)
        addWaves(A HalfNote 4)(C HalfNote 5)
        addWaves(B Black 4)(D Black 5)
        E Black 5

        C Black 5
        A Black 4
        A Black 4
        Sil Silence 0

        addWaves(C White 4)(E White 4)
        addWaves(A White 3)(C White 4)
        
        addWaves(B White 3)(D White 4)
        addWaves(GDiese White 3)(B White 3)

        addWaves(A White 3)(C White 4)
        addWaves(E White 3)(A White 3)

        addWaves(E White 3)(GDiese White 3)
        addWaves(G White 3)(B White 3)

        addWaves(C White 4)(E White 4)
        addWaves(A White 3)(C White 4)
        
        addWaves(B White 3)(D White 4)
        addWaves(GDiese White 3)(B White 3)

        addWaves(A Black 3)(C Black 4)
        addWaves(C Black 4)(E Black 4)
        addWaves(E Black 4)(A Black 4)
        addWaves(E Black 4)(A Black 4)

        addWaves3(B Round 3)(F Round 4)(GDiese Round 4)

        E Black 5
        addWaves(GDiese HalfNote 4)(B HalfNote 4)
        C HalfNote 5
        D Black 5
        addWaves(A HalfNote 4)(C HalfNote 5)
        addWaves(G HalfNote 4)(B HalfNote 4)

        addWaves(E Black 4)(A Black 4)
        A HalfNote 4
        C HalfNote 5
        E Black 5
        D HalfNote 5
        C HalfNote 5

        addWaves(GDiese Black 4)(B Black 4)
        addWaves(G HalfNote 4)(B HalfNote 4)
        addWaves(A HalfNote 4)(C HalfNote 5)
        addWaves(B Black 4)(D Black 5)
        E Black 5

        C Black 5
        A Black 4
        A Black 4
        Sil Silence 0

        HalfSil HalfSilence 0
        addWaves(F Black 4)(D Black 5)
        addWaves(A HalfNote 4)(F HalfNote 5)
        addWaves(C Black 5)(A Black 5)
        addWaves(B HalfNote 4)(G HalfNote 5)
        addWaves(A HalfNote 4)(F HalfNote 5)

        addWaves(G PBlack 4)(E PBlack 5)
        addWaves(E HalfNote 4)(C HalfNote 4)
        addWaves(G Black 4)(E Black 5)
        addWaves(F HalfNote 4)(D HalfNote 5)
        addWaves(E HalfNote 4)(C HalfNote 5)

        addWaves(GDiese Black 4)(B Black 4)
        addWaves(G HalfNote 4)(B HalfNote 4)
        addWaves(A HalfNote 4)(C HalfNote 5)
        addWaves(B Black 4)(D Black 5)
        E Black 5

        C Black 5
        A Black 4
        A Black 4
        Sil Silence 0
        |]

    let Numb = [|
        // Intro
        CDiese QuarterNote 5
        E QuarterNote 5
        CDiese QuarterNote 5
        FDiese PHalfNote 5
        A PHalfNote 5
        GDiese PBlack 5
        CDiese QuarterNote 5
        E QuarterNote 5
        CDiese QuarterNote 5
        A PHalfNote 5
        GDiese PHalfNote 5
        E PBlack 5
        CDiese QuarterNote 5
        E QuarterNote 5
        CDiese QuarterNote 5
        FDiese PHalfNote 5
        A PHalfNote 5
        GDiese PBlack 5
        CDiese QuarterNote 5
        E QuarterNote 5
        CDiese QuarterNote 5
        A PHalfNote 5
        GDiese PHalfNote 5
        E PBlack 5
        CDiese QuarterNote 5
        E QuarterNote 5
        CDiese QuarterNote 5
        HalfSil HalfSilence 0

        // First Verse
        FDiese QuarterNote 4
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        D QuarterNote 5
        CDiese HalfNote 5
        CDiese QuarterNote 5
        B QuarterNote 4
        A PHalfNote 4
        HalfSil HalfSilence 0
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        B QuarterNote 4
        A HalfNote 4
        B HalfNote 4
        E QuarterNote 4
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        B QuarterNote 4
        A HalfNote 4
        B HalfNote 4
        HalfSil HalfSilence 0

        FDiese QuarterNote 4
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        D QuarterNote 5
        CDiese HalfNote 5
        CDiese QuarterNote 5
        B QuarterNote 4
        A PHalfNote 4
        HalfSil HalfSilence 0
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        B QuarterNote 4
        A HalfNote 4
        B PHalfNote 4
        CDiese QuarterNote 5
        B HalfNote 4
        A HalfNote 4
        B HalfNote 4
        CDiese Black 5
        Sil Silence 0
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        E QuarterNote 5
        CDiese Triolet 5
        Sil Silence 0
        CDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        E QuarterNote 5
        CDiese HalfNote 5
        D HalfNote 5
        E PBlack 5
        HalfSil HalfSilence 0

        // Chorus
        FDiese PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        GDiese HalfNote 5
        E PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        GDiese HalfNote 5
        E PHalfNote 5
        FDiese EightNote 5
        FDiese EightNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5

        // Second Verse
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        E QuarterNote 5
        E QuarterNote 5
        FDiese QuarterNote 5
        E QuarterNote 5
        E QuarterNote 5
        E Black 5
        HalfSil HalfSilence 0
        FDiese QuarterNote 5
        E QuarterNote 5
        E QuarterNote 5
        E HalfNote 5
        CDiese HalfNote 5
        FDiese QuarterNote 4
        D QuarterNote 5
        CDiese QuarterNote 5
        B QuarterNote 4
        B HalfNote 4
        CDiese HalfNote 5
        CDiese HalfNote 5
        QSilence QuarterSilence 0

        FDiese QuarterNote 4
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        D QuarterNote 5
        CDiese HalfNote 5
        CDiese QuarterNote 5
        B QuarterNote 4
        A PHalfNote 4
        HalfSil HalfSilence 0

        CDiese QuarterNote 5
        CDiese QuarterNote 5
        B QuarterNote 4
        A Black 4
        HalfSil HalfSilence 0
        CDiese QuarterNote 5
        B HalfNote 4
        A HalfNote 4
        B HalfNote 4
        CDiese Black 5
        Sil Silence 0
        Sil Silence 0
        HalfSil HalfSilence 0

        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        E QuarterNote 5
        CDiese Triolet 5
        Sil Silence 0
        CDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        E QuarterNote 5
        CDiese HalfNote 5
        D HalfNote 5
        E PBlack 5
        Sil Silence 0
        Sil Silence 0
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        E QuarterNote 5
        CDiese HalfNote 5
        QSilence QuarterSilence 0
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        A Triolet 5
        GDiese Triolet 5
        GDiese QuarterNote 5
        A HalfNote 5
        GDiese PHalfNote 5

        // Chorus
        FDiese PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        GDiese HalfNote 5
        E PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        GDiese HalfNote 5
        E PHalfNote 5
        FDiese EightNote 5
        FDiese EightNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        HalfSil HalfSilence 0

        // Third Verse
        FDiese QuarterNote 5
        A QuarterNote 5
        GDiese Black 5
        HalfSil HalfSilence 0
        FDiese QuarterNote 5
        GDiese HalfNote 5
        A Black 5
        GDiese Black 5
        A Black 5
        GDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        Sil Silence 0
        QSilence QuarterSilence 0
        FDiese QuarterNote 5
        A QuarterNote 5
        GDiese PHalfNote 5
        Sil Silence 0
        GDiese QuarterNote 5
        FDiese QuarterNote 5
        GDiese QuarterNote 5
        GDiese HalfNote 5
        GDiese HalfNote 5
        FDiese QuarterNote 5
        GDiese QuarterNote 5
        FDiese QuarterNote 5
        GDiese QuarterNote 5
        GDiese HalfNote 5
        GDiese HalfNote 5
        FDiese QuarterNote 5
        A QuarterNote 5
        GDiese PHalfNote 5
        HalfSil HalfSilence 0

        // Chorus
        FDiese PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        GDiese HalfNote 5
        E PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        GDiese HalfNote 5
        E PHalfNote 5
        FDiese EightNote 5
        FDiese EightNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese HalfNote 5
        FDiese QuarterNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese PBlack 5
        Sil Silence 0
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        CDiese QuarterNote 5
        D QuarterNote 5
        CDiese HalfNote 5
        CDiese QuarterNote 5
        B QuarterNote 4
        A PHalfNote 4
        HalfSil HalfSilence 0
        FDiese PHalfNote 5
        FDiese QuarterNote 5
        FDiese HalfNote 5
        E HalfNote 5
        FDiese PBlack 5
        HalfSil HalfSilence 0
        A White 5
        GDiese Black 5

        // Outro
        CDiese QuarterNote 5
        E QuarterNote 5
        CDiese QuarterNote 5
        FDiese PHalfNote 5
        A PHalfNote 5
        GDiese PBlack 5
        CDiese QuarterNote 5
        E QuarterNote 5
        CDiese QuarterNote 5
        A PHalfNote 5
        GDiese PHalfNote 5
        E PBlack 5
        |]
    
    let InTheEnd = [| // Tempo: 60
        // Intro
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F PHalfNote 4; // Reverb needed
        ADiese Triolet 3;
        ADiese HalfNote 3;
        B HalfNote 3;
        ADiese QuarterNote 3;

        // First Verse
        F White 5;
        ADiese PBlack 5;
        FDiese HalfNote 5;
        F White 5;
        DDiese Black 5;
        ADiese HalfNote 3;
        B Triolet 3;
        ADiese QuarterNote 3;
        F White 5;
        ADiese PBlack 5;
        FDiese HalfNote 5;
        F White 5;
        DDiese Black 5;
        ADiese HalfNote 3;
        B HalfNote 3;
        ADiese QuarterNote 3;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        CDiese HalfNote 4;
        DDiese HalfNote 4;
        F QuarterNote 4;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F PHalfNote 4;
        HalfSil HalfSilence 0;

        // Chorus
        ADiese Triolet 3;
        CDiese HalfNote 4;
        DDiese HalfNote 4;
        DDiese QuarterNote 4;
        F HalfNote 4;
        F Triolet 4;
        F Triolet 4;
        CDiese HalfNote 4;
        CDiese PBlack 4;
        ADiese EightNote 3;
        CDiese EightNote 4;
        DDiese QuarterNote 4;
        F PHalfNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        DDiese Triolet 4;
        ADiese Triolet 3;
        CDiese HalfNote 4;
        DDiese HalfNote 4;
        DDiese QuarterNote 4;
        F HalfNote 4;
        F Triolet 4;
        F Triolet 4;
        CDiese HalfNote 4;
        CDiese PBlack 4;
        ADiese EightNote 3;
        CDiese EightNote 4;
        DDiese QuarterNote 4;
        F PHalfNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        CDiese Triolet 4;
        DDiese EightNote 4;
        CDiese EightNote 4;
        ADiese EightNote 3;
        HalfSil HalfSilence 0;

        // Second Verse
        F White 5;
        ADiese PBlack 5;
        FDiese HalfNote 5;
        F White 5;
        DDiese Black 5;
        ADiese HalfNote 3;
        B Triolet 3;
        ADiese QuarterNote 3;
        F White 5;
        ADiese PBlack 5;
        FDiese HalfNote 5;
        F White 5;
        DDiese Black 5;
        ADiese HalfNote 3;
        B HalfNote 3;
        ADiese QuarterNote 3;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        CDiese HalfNote 4;
        DDiese HalfNote 4;
        F QuarterNote 4;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F HalfNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        DDiese HalfNote 4;
        ADiese HalfNote 4;
        ADiese HalfNote 4;
        FDiese HalfNote 4;
        F PHalfNote 4;
        HalfSil HalfSilence 0;

        // Chorus
        ADiese Triolet 3;
        CDiese HalfNote 4;
        DDiese HalfNote 4;
        DDiese QuarterNote 4;
        F HalfNote 4;
        F Triolet 4;
        F Triolet 4;
        CDiese HalfNote 4;
        CDiese PBlack 4;
        ADiese EightNote 3;
        CDiese EightNote 4;
        DDiese QuarterNote 4;
        F PHalfNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        DDiese Triolet 4;
        HalfSil HalfSilence 0;
        ADiese Triolet 3;
        CDiese HalfNote 4;
        DDiese HalfNote 4;
        DDiese QuarterNote 4;
        F HalfNote 4;
        F Triolet 4;
        F Triolet 4;
        CDiese HalfNote 4;
        CDiese PBlack 4;
        ADiese EightNote 3;
        CDiese EightNote 4;
        DDiese QuarterNote 4;
        F PHalfNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        CDiese Triolet 4;
        DDiese EightNote 4;
        CDiese EightNote 4;
        ADiese EightNote 3;
        HalfSil HalfSilence 0;

        // Third Verse
        FDiese Triolet 3;
        CDiese Triolet 4;
        CDiese HalfNote 4;
        CDiese PBlack 4;
        FDiese PHalfNote 3;
        GDiese HalfNote 3;
        ADiese PHalfNote 3;
        CDiese Triolet 4;
        CDiese Triolet 4;
        CDiese HalfNote 4;
        FDiese HalfNote 3;
        FDiese HalfNote 3;
        ADiese HalfNote 3;
        GDiese PBlack 3;
        CDiese Triolet 4;
        CDiese Triolet 4;
        CDiese PHalfNote 4;
        FDiese HalfNote 3;
        FDiese HalfNote 3;
        FDiese HalfNote 3;
        ADiese HalfNote 3;
        GDiese HalfNote 3;
        FDiese HalfNote 3;
        ADiese HalfNote 3;
        GDiese PBlack 3;
        ADiese EightNote 3;
        GDiese EightNote 3;
        FDiese QuarterNote 3;
        HalfSil HalfSilence 0;
        ADiese Triolet 3;
        FDiese Triolet 4;
        FDiese HalfNote 4;
        FDiese PBlack 4;
        DDiese PHalfNote 4;
        F PBlack 4;
        FDiese Triolet 4;
        FDiese Triolet 4;
        FDiese HalfNote 4;
        DDiese HalfNote 4;
        DDiese HalfNote 4;
        FDiese HalfNote 4;
        FDiese PBlack 4;
        FDiese Triolet 4;
        FDiese Triolet 4;
        FDiese PHalfNote 4;
        DDiese HalfNote 4;
        DDiese Triolet 4;
        DDiese Triolet 4;
        FDiese HalfNote 4;
        F HalfNote 4;
        DDiese HalfNote 4;
        FDiese HalfNote 4;
        F PBlack 4;
        FDiese EightNote 4;
        F EightNote 4;
        DDiese Triolet 4;
        HalfSil HalfSilence 0;

        // Chorus
        ADiese Triolet 3;
        CDiese HalfNote 4;
        DDiese HalfNote 4;
        DDiese QuarterNote 4;
        F HalfNote 4;
        F Triolet 4;
        F Triolet 4;
        CDiese HalfNote 4;
        CDiese PBlack 4;
        ADiese EightNote 3;
        CDiese EightNote 4;
        DDiese QuarterNote 4;
        F PHalfNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        DDiese Triolet 4;
        ADiese Triolet 3;
        CDiese HalfNote 4;
        DDiese HalfNote 4;
        DDiese QuarterNote 4;
        F HalfNote 4;
        F Triolet 4;
        F Triolet 4;
        CDiese HalfNote 4;
        CDiese PBlack 4;
        ADiese EightNote 3;
        CDiese EightNote 4;
        DDiese QuarterNote 4;
        F PHalfNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        F QuarterNote 4;
        FDiese QuarterNote 4;
        F QuarterNote 4;
        DDiese QuarterNote 4;
        CDiese Triolet 4;
        DDiese EightNote 4;
        CDiese EightNote 4;
        ADiese EightNote 3;
        HalfSil HalfSilence 0;

        // Outro
        DDiese PHalfNote 4;
        ADiese PHalfNote 4;
        ADiese PHalfNote 4;
        FDiese PHalfNote 4;
        F PHalfNote 4;
        F PHalfNote 4;
        F PHalfNote 4;
        F HalfNote 4;
        FDiese HalfNote 4;
        DDiese PHalfNote 4;
        ADiese PHalfNote 4;
        ADiese PHalfNote 4;
        FDiese PHalfNote 4;
        F PHalfNote 4;
        F PHalfNote 4;
        F PHalfNote 4;
        F HalfNote 4;
        FDiese HalfNote 4;
        DDiese PHalfNote 4;
        ADiese PHalfNote 4;
        ADiese PHalfNote 4;
        FDiese PHalfNote 4;
        F PHalfNote 4;
        F PHalfNote 4;
        F PHalfNote 4;
        F HalfNote 4;
        FDiese PBlack 4;
        DDiese HalfNote 4;
        FDiese HalfNote 4;
        ADiese HalfNote 4;
        DDiese HalfNote 5;
        F HalfNote 5;
        FDiese HalfNote 5;
        F PBlack 5;
        |]
    
    let GoldenWind =[| //tempo 150
        addWaves(B Black 3)(B Black 4)
        D QuarterNote 5
        CDiese QuarterNote 5
        B HalfNote 4
        A PHalfNote 4
        B PHalfNote 4
        B PHalfNote 4
        QSilence QuarterSilence 0
        FDiese HalfNote 4
        A HalfNote 4
        B HalfNote 4
        CDiese PHalfNote 5
        A PHalfNote 4
        B PHalfNote 4
        QSilence QuarterSilence 0
        HalfSil HalfSilence 0
        D QuarterNote 5
        C QuarterNote 5
        B HalfNote 4
        A PHalfNote 4
        B HalfNote 4
        B HalfNote 4
        QSilence QuarterSilence  0
        FDiese HalfNote 4
        CDiese HalfNote 5
        D HalfNote 5
        CDiese PHalfNote 5
        A PHalfNote 4
        E HalfNote 4
        QSilence QuarterSilence 0
        HalfSil HalfSilence 0
        D QuarterNote 5
        C QuarterNote 5
        B HalfNote 4
        addWaves( A PHalfNote 4)(A PHalfNote 5)
        addWaves(B PHalfNote 4)(B PHalfNote 5) 
        addWaves(B PHalfNote 4)(B PHalfNote 5) 
        QSilence QuarterSilence  0
        addWaves(FDiese HalfNote 4)(FDiese HalfNote 5)
        addWaves(A PHalfNote 4)(A PHalfNote 5)
        addWaves(B PHalfNote 4)(B PHalfNote 5)
        addWaves(CDiese PHalfNote 5)(CDiese PHalfNote 6)
        addWaves(A PHalfNote 4)(A PHalfNote 5)
        addWaves(B PHalfNote 4)(B PHalfNote 5) 
        QSilence QuarterSilence   0
        HalfSil HalfSilence 0
        addWaves(D QuarterNote 5)(D QuarterNote 6)
        addWaves(C QuarterNote 5)(C QuarterNote 6)
        addWaves(B HalfNote 4)(B HalfNote 5)
        addWaves(B Triolet 4)(B Triolet 5)
        addWaves(D Triolet 4)(D Triolet 5)
        addWaves(FDiese Triolet 5)(FDiese Triolet 6)
        addWaves(E Triolet 5)(E Triolet 6)
        addWaves(D Triolet 5)(D Triolet 6)
        addWaves(B Triolet 5)(B Triolet 6)
        addWaves(A Triolet 5)(A Triolet 6)
        addWaves(GDiese Triolet 5)(GDiese Triolet 6)
        addWaves(FDiese Triolet 5)(FDiese Triolet 6)
        addWaves(D Triolet 5)(D Triolet 6)
        addWaves(CDiese Triolet 5)(CDiese Triolet 6)
        addWaves(B Triolet 5)(B Triolet 6)
        
        
        A QuarterNote 4
        B HalfNote 4
        A QuarterNote 4
        B HalfNote 4
        A QuarterNote 4
        B HalfNote 4
        A QuarterNote 4
        B HalfNote 4
        B QuarterNote 4
        CDiese QuarterNote 5
        D QuarterNote 5
        E QuarterNote 5
        
        addWaves3(B Black 4)(D Black 5)(FDiese Black 5) // JOJO (more GIO GIO huh)
        HalfSil HalfSilence 0
        addWaves3(GDiese HalfNote 4)(B HalfNote 4)(F HalfNote 5)
        addWaves3(GDiese PBlack 4)(B PBlack 4)(F PBlack 5)
        D QuarterNote 5
        E QuarterNote 5

        addWaves3(GDiese PHalfNote 4)(B PHalfNote 4)(FDiese PHalfNote 5)
        F QuarterNote 5
        F HalfNote 5
        D HalfNote 5
        addWaves3(E PHalfNote 4)(ADiese PHalfNote 4)(CDiese PHalfNote 5)
        D QuarterNote 5
        D HalfNote 5
        E HalfNote 5

        addWaves3(B Black 4)(D Black 5)(FDiese Black 5)
        F HalfNote 5
        addWaves3(F HalfNote 5)(GDiese HalfNote 5)(B HalfNote 5)
        addWaves3(F Black 5)(GDiese Black 5)(B Black 5) 
        E HalfNote 4
        CDiese HalfNote 5

        addWaves3(GDiese PHalfNote 4)(B PHalfNote 4)(D PHalfNote 5)
        E QuarterNote 5
        E HalfNote 5
        D PHalfNote 5
        addWaves3(E PHalfNote 4)(ADiese PHalfNote 4)(CDiese PHalfNote 5)
        A QuarterNote 5
        A HalfNote 5
        G HalfNote 5

        addWaves3(B Black 4)(D Black 5)(FDiese Black 5)
        HalfSil HalfSilence 0
        addWaves3(GDiese HalfNote 4)(B HalfNote 4)(F HalfNote 5)
        addWaves3(GDiese PBlack 4)(B PBlack 4)(F PBlack 5)
        D QuarterNote 5
        E QuarterNote 5

        addWaves3(GDiese PHalfNote 4)(B PHalfNote 4)(FDiese PHalfNote 5)
        F QuarterNote 5
        F HalfNote 5
        D HalfNote 5
        addWaves3(E PHalfNote 4)(ADiese PHalfNote 4)(CDiese PHalfNote 5)
        D QuarterNote 5
        D HalfNote 5 
        E HalfNote 5

        addWaves3(B Black 4)(D Black 4)(FDiese Black 5)
        F HalfNote 5
        addWaves3(F HalfNote 5)(GDiese HalfNote 5)(B HalfNote 5)
        addWaves3(F Black 5)(GDiese Black 5)(B Black 5) 
        E HalfNote 5
        CDiese HalfNote 6
       
        addWaves3(GDiese PHalfNote 6)(B PHalfNote 6)(D PHalfNote 6)
        G QuarterNote 5
        G HalfNote 5
        FDiese HalfNote 5
        F PHalfNote 5
        D QuarterNote 6
        D HalfNote 6
        ADiese HalfNote 5
        
        addWaves3(D Black 6)(FDiese Black 6)(B Black 6)

        |]

    let Lac = [| // Tempo: 100
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

    let Solvieg =[| // Tempo: 90
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

    let Gadjet = [| // Tempo: 80
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
        
    // Beginning of Unravel song 
    let Unravel = [| // Tempo: 120
        ADiese HalfNote 5
        C Black 6
        ADiese Black 5
        A HalfNote 5
        G Black 5
        C Black 6
        ADiese Black 5
        A Black 5
        G Black 5
        G HalfNote 5
        F PBlack 5
        DDiese PBlack 5
        DDiese Black 5
        F HalfNote 5
        D Black 5
        |]

    // La Vie En Rose, Edith Piaf
    let LVER = [| // Tempo: 70
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
        
    let Kalinka = [| // Tempo: 90
        
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
        G HalfNote 5;
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
        G HalfNote 5;
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
        
        D Black 6;
        C HalfNote 6;
        B HalfNote 5;
        A Black 5;
        Sil Silence 0;
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

    let TOM = [| // Tempo: 170
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
        // Repeat
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

        // Chorus
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

    let ZeldaOverworld = [| // Tempo: 130
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

        A Black 5
        E PBlack 5
        A HalfNote 5
        A QuarterNote 5
        B QuarterNote 5
        CDiese QuarterNote 6
        D QuarterNote 6
        E White 6
        HalfSil HalfSilence 6
        E HalfNote 6
        E Triolet 6
        F Triolet 6
        G Triolet 6
        A White 6
        HalfSil HalfSilence 6
        A HalfNote 6
        A Triolet 6
        G Triolet 6
        F Triolet 6
        G PHalfNote 6
        F QuarterNote 6
        E White 6
        E Black 6
        D HalfNote 6
        D QuarterNote 6
        E QuarterNote 6
        F White 6
        E HalfNote 6
        D HalfNote 6
        C HalfNote 6
        C QuarterNote 6
        D QuarterNote 6
        E White 6
        D HalfNote 6
        C HalfNote 6
        B HalfNote 5
        B QuarterNote 5
        CDiese QuarterNote 6
        DDiese White 6
        FDiese Black 6
        E HalfNote 6
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
        A Black 5
        E PBlack 5
        A HalfNote 5
        A QuarterNote 5
        B QuarterNote 5
        CDiese QuarterNote 6
        D QuarterNote 6
        E White 6
        HalfSil HalfSilence 6
        E HalfNote 6
        E Triolet 6
        F Triolet 6
        G Triolet 6
        A White 6
        Sil Silence 6
        C Black 7
        B Black 6
        GDiese White 6
        E Black 6
        F PWhite 6
        A Black 6
        GDiese Black 6
        E White 6
        E Black 6
        F PWhite 6
        A Black 6
        GDiese Black 6
        E White 6
        CDiese Black 6
        D PWhite 6
        F Black 6
        E Black 6
        C White 6
        A Black 5
        B HalfNote 5
        B QuarterNote 5
        CDiese QuarterNote 6
        DDiese White 6
        FDiese Black 6
        E HalfNote 6
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
    
    let Crazy = [| // Tempo: 200
        D Black 5
        Sil Silence 0
        F Black 5
        HalfSil HalfSilence 0
        D HalfNote 5
        HalfSil HalfSilence 0
        D HalfNote 5
        G Black 5
        D Black 5
        C Black 5
        D Black 5
        Sil Silence 0
        A Black 5
        HalfSil HalfSilence 0
        D HalfNote 5
        HalfSil HalfSilence 0
        D HalfNote 5
        ADiese Black 5
        A Black 5
        F Black 5
        D Black 5
        A Black 5
        D Black 6
        D HalfNote 5
        C HalfNote 5
        HalfSil HalfSilence 0
        C HalfNote 5
        A Black 4
        E Black 5
        D Black 5
        Sil Silence 0
        D HalfNote 5
        HalfSil HalfSilence 0
        D Black 5
        D HalfNote 5
        C HalfNote 5
        HalfSil HalfSilence 0
        C HalfNote 5 
        HalfSil HalfSilence 0
        C HalfNote 5
        A Black 4
        C Black 5
        Sil Silence 0
        A HalfNote 5
        HalfSil HalfSilence 0
        A HalfNote 5
        HalfSil HalfSilence 0
        A HalfNote 5
        C HalfNote 6
        HalfSil HalfSilence 0
        C HalfNote 6
        HalfSil HalfSilence 0
        C HalfNote 6
        B HalfNote 5
        HalfSil HalfSilence 0
        B HalfNote 5
        HalfSil HalfSilence 0
        Sil Silence 0
        A HalfNote 5
        HalfSil HalfSilence 0
        A HalfNote 5
        HalfSil HalfSilence 0
        A HalfNote 5
        C HalfNote 6
        HalfSil HalfSilence 0
        C HalfNote 6
        B HalfNote 5
        HalfSil HalfSilence 0
        A HalfNote 5
        HalfSil HalfSilence 0
        Sil Silence 0
        Sil Silence 0
        F HalfNote 5
        HalfSil HalfSilence 0
        F HalfNote 5
        HalfSil HalfSilence 0
        F HalfNote 5
        HalfSil HalfSilence 0
        F HalfNote 5
        G HalfNote 5
        HalfSil HalfSilence 0
        G HalfNote 5
        HalfSil HalfSilence 0
        G HalfNote 5
        G Black 5
        G Black 5
        A HalfNote 5
        HalfSil HalfSilence 0
        A HalfNote 5
        HalfSil HalfSilence 0
        A HalfNote 5
        HalfSil HalfSilence 0
        G HalfNote 5
        A HalfNote 5
        HalfSil HalfSilence 0
        A HalfNote 5
        A White 5
        |]

    let Amogus = [| // Tempo: 100
        A HalfNote 5
        C HalfNote 6
        D HalfNote 6
        DDiese HalfNote 6
        D HalfNote 6
        C HalfNote 6
        A PHalfNote 5
        Sil Silence 0
        G QuarterNote 5
        C QuarterNote 6
        A QuarterNote 5
        |]

    let LettreAElise = [| // tempo 105
        E QuarterNote 5
        DDiese QuarterNote 5
        E QuarterNote 5
        DDiese QuarterNote 5
        E QuarterNote 5
        B QuarterNote 4
        D QuarterNote 5
        C QuarterNote 5
        A HalfNote 4
        Sil Silence 4
        C QuarterNote 4
        E QuarterNote 4
        A QuarterNote 4
        B QuarterNote 4
        Sil Silence 4
        E QuarterNote 4
        GDiese QuarterNote 4
        B QuarterNote 4
        C HalfNote 5
        Sil Silence 4
        E QuarterNote 4
        E QuarterNote 5
        DDiese QuarterNote 5
        E QuarterNote 5
        DDiese QuarterNote 5
        E QuarterNote 5
        B QuarterNote 4
        D QuarterNote 5
        C QuarterNote 5
        A HalfNote 4
        Sil Silence 4
        C QuarterNote 4
        E QuarterNote 4
        A QuarterNote 4
        B QuarterNote 4
        Sil Silence 4
        E QuarterNote 4
        C QuarterNote 5
        B QuarterNote 4
        A QuarterNote 4

    |]

    let weAre = [|
        HalfSil HalfSilence 0
        A HalfNote 5
        A HalfNote 5
        A HalfNote 5
        HalfSil HalfSilence 0
        F HalfNote 5
        HalfSil HalfSilence 0
        G HalfNote 5
        HalfSil HalfSilence 0
        DDiese HalfNote 5
        HalfSil HalfSilence 0
        F HalfNote 5
        HalfSil HalfSilence 0
        DDiese HalfNote 4
        F Black 5
        G White 5
        MSil MSilence 0
        MSil MSilence 0
        HalfSil HalfSilence 0
        A HalfNote 5
        A HalfNote 5
        A HalfNote 5
        HalfSil HalfSilence 0
        F HalfNote 5
        HalfSil HalfSilence 0
        G HalfNote 5
        HalfSil HalfSilence 0
        DDiese HalfNote 5
        HalfSil HalfSilence 0
        F HalfNote 5
        HalfSil HalfSilence 0
        DDiese HalfNote 5
        F Black 5
        C Black 5
        DDiese HalfNote 5
        DDiese Black 5
        FDiese Black 5
        G HalfNote 5
        F HalfNote 5
        F Black 5
        DDiese Black 5
        B HalfNote 5
        B Round 5
        E HalfNote 6
        HalfSil HalfSilence 0
        DDiese HalfNote 5
        HalfSil HalfSilence 0
        CDiese White 5
        B Black 5
        CDiese HalfNote 5
        D HalfNote 5
        B HalfNote 5
        D HalfNote 5
        DDiese HalfNote 5
        Sil Silence 0
        DDiese HalfNote 5
        HalfSil HalfSilence 0
        CDiese White 5
        B Black 5
        CDiese HalfNote 5
        D HalfNote 5
        ADiese HalfNote 4
        ADiese Black 4
        Sil Silence 0
        DDiese HalfNote 5
        HalfSil HalfSilence 0
        CDiese White 5
        ADiese Black 4
        CDiese HalfNote 5
        D HalfNote 5
        ADiese HalfNote 4
        D HalfNote 5
        DDiese HalfNote 5
        Sil Silence 0
        G Black 4
        A Black 4
        B Black 5
    |]

    let GaurPlain = [|  //tempo 120
    
        G QuarterNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        C QuarterNote 5
        D PWhite 5
        G QuarterNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        C QuarterNote 5
        D PWhite 5
        G QuarterNote 4
        A QuarterNote 4
        C QuarterNote 5
        D QuarterNote 5
        C PBlack 5
        G PHalfNote 4
        G HalfNote 4
        A HalfNote 4
        ADiese PHalfNote 4
        ADiese PHalfNote 4
        C HalfNote 5
        A Black 4
        F Black 4
        D PWhite 5
        D Triolet 5
        DDiese Triolet 5
        F Triolet 5
        D PWhite 5
        D Triolet 5
        DDiese Triolet 5
        G Triolet 5
        F PBlack 5
        A Black 4
        G HalfNote 4
        A HalfNote 4
        ADiese PHalfNote 4
        ADiese QuarterNote 4
        HalfSil HalfSilence 4
        C HalfNote 5
        D HalfNote 5
        C HalfNote 5
        ADiese HalfNote 4
        A HalfNote 4

        // part which is repeated
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C Black 5
        ADiese HalfNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        A QuarterNote 4
        G QuarterNote 4
        D PWhite 4
        A QuarterNote 5
        ADiese QuarterNote 5
        A QuarterNote 5
        G QuarterNote 5
        D PWhite 5
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C HalfNote 5
        ADiese HalfNote 4
        D Round 5
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C Black 5
        ADiese HalfNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        A QuarterNote 4
        G QuarterNote 4
        D PWhite 4
        A QuarterNote 5
        ADiese QuarterNote 5
        A QuarterNote 5
        G QuarterNote 5
        D Black 5
        Sil Silence 5
        F QuarterNote 4
        C QuarterNote 4
        D QuarterNote 4
        F QuarterNote 4
        G PHalfNote 4
        G QuarterNote 4
        HalfSil HalfSilence 4
        G HalfNote 4
        F PHalfNote 4
        F QuarterNote 4
        HalfSil HalfSilence 4
        D QuarterNote 4
        F QuarterNote 4
        G PHalfNote 4
        G QuarterNote 4
        HalfSil HalfSilence 4
        G HalfNote 4
        A HalfNote 4
        HalfSil HalfSilence 4
        D HalfNote 4
        HalfSil HalfSilence 4

        // 2nd page
        C Black 4
        C Black 4
        C Black 4
        Sil Silence 3
        A PBlack 4
        G HalfNote 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        F PBlack 5
        DDiese HalfNote 5
        ADiese White 4
        DDiese PBlack 5
        D HalfNote 5
        A White 4
        C Black 5
        ADiese Black 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        G PWhite 5
        G QuarterNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        D QuarterNote 5
        G White 5
        A White 5
        A PBlack 5
        G QuarterNote 5
        A QuarterNote 5
        ADiese White 5
        Sil Silence 3
        FDiese HalfNote 4
        G HalfNote 4
        A HalfNote 4
        ADiese HalfNote 4
        A PBlack 4
        G HalfNote 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        F PBlack 5
        DDiese HalfNote 5
        ADiese White 4
        DDiese PBlack 5
        D HalfNote 5
        A White 4
        C Black 5
        ADiese Black 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        G PWhite 5
        G QuarterNote 4
        ADiese QuarterNote 4
        D QuarterNote 5
        G QuarterNote 5
        G White 5
        A White 5
        G Round 5

        // 1st repeat
        G Black 5
        F QuarterNote 5
        DDiese QuarterNote 5
        D QuarterNote 5
        C Black 5
        DDiese Black 4
        D PBlack 4
        DDiese HalfNote 4
        F PBlack 4
        DDiese HalfNote 4
        D PBlack 4
        C HalfNote 4
        F PBlack 3
        ADiese HalfNote 3
        A PBlack 3
        ADiese HalfNote 3
        C PBlack 4
        A HalfNote 3
        A PBlack 3
        ADiese QuarterNote 3
        A QuarterNote 3
        G White 3
        D PBlack 4
        DDiese HalfNote 4
        F PBlack 4
        DDiese HalfNote 4
        A PBlack 4
        G QuarterNote 4
        A QuarterNote 4
        ADiese White 4
        C PBlack 5
        ADiese HalfNote 4
        A White 4
        ADiese PHalfNote 4
        C QuarterNote 5 
        HalfSil HalfSilence 4
        ADiese HalfNote 4
        A Black 4
        F Black 4

        // part which is repeated
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C Black 5
        ADiese HalfNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        A QuarterNote 4
        G QuarterNote 4
        D PWhite 4
        A QuarterNote 5
        ADiese QuarterNote 5
        A QuarterNote 5
        G QuarterNote 5
        D PWhite 5
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C HalfNote 5
        ADiese HalfNote 4
        D Round 5
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C Black 5
        ADiese HalfNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        A QuarterNote 4
        G QuarterNote 4
        D PWhite 4
        A QuarterNote 5
        ADiese QuarterNote 5
        A QuarterNote 5
        G QuarterNote 5
        D Black 5
        Sil Silence 5
        F QuarterNote 4
        C QuarterNote 4
        D QuarterNote 4
        F QuarterNote 4
        G PHalfNote 4
        G QuarterNote 4
        HalfSil HalfSilence 4
        G HalfNote 4
        F PHalfNote 4
        F QuarterNote 4
        HalfSil HalfSilence 4
        D QuarterNote 4
        F QuarterNote 4
        G PHalfNote 4
        G QuarterNote 4
        HalfSil HalfSilence 4
        G HalfNote 4
        A HalfNote 4
        HalfSil HalfSilence 4
        D HalfNote 4
        HalfSil HalfSilence 4

        // 2nd page
        C Black 4
        C Black 4
        C Black 4
        Sil Silence 3
        A PBlack 4
        G HalfNote 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        F PBlack 5
        DDiese HalfNote 5
        ADiese White 4
        DDiese PBlack 5
        D HalfNote 5
        A White 4
        C Black 5
        ADiese Black 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        G PWhite 5
        G QuarterNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        D QuarterNote 5
        G White 5
        A White 5
        A PBlack 5
        G QuarterNote 5
        A QuarterNote 5
        ADiese White 5
        Sil Silence 3
        FDiese HalfNote 4
        G HalfNote 4
        A HalfNote 4
        ADiese HalfNote 4
        A PBlack 4
        G HalfNote 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        F PBlack 5
        DDiese HalfNote 5
        ADiese White 4
        DDiese PBlack 5
        D HalfNote 5
        A White 4
        C Black 5
        ADiese Black 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        G PWhite 5
        G QuarterNote 4
        ADiese QuarterNote 4
        D QuarterNote 5
        G QuarterNote 5
        G White 5
        A White 5
        G Round 5

        //2nd repeat  3rd page  2:34
        G Black 5
        F QuarterNote 5
        DDiese QuarterNote 5
        D QuarterNote 5
        C Black 5
        ADiese Black 4
        A PBlack 4
        G HalfNote 4
        A PBlack 4
        G HalfNote 4
        F PBlack 4
        DDiese HalfNote 4
        F PBlack 4
        ADiese HalfNote 4
        A PBlack 4
        G HalfNote 4
        A PBlack 4
        ADiese HalfNote 4
        C PBlack 5
        D HalfNote 5
        F PBlack 4
        ADiese HalfNote 4
        A PBlack 4
        G HalfNote 4
        A PBlack 4
        G HalfNote 4
        F PBlack 4
        DDiese HalfNote 4
        F PBlack 4
        DDiese HalfNote 4
        D White 4
        DDiese White 4
        C White 4
        D PBlack 4
        ADiese HalfNote 5
        A PBlack 5
        G HalfNote 5
        A PBlack 5
        G HalfNote 5
        F PBlack 5
        DDiese HalfNote 5
        F PBlack 5
        ADiese HalfNote 5  // 2:50
        A PBlack 5
        G HalfNote 5
        A PBlack 5
        ADiese HalfNote 5
        C PBlack 6
        D HalfNote 6
        F PBlack 5
        ADiese HalfNote 5
        A PBlack 5
        G HalfNote 5
        A PBlack 5
        G HalfNote 5
        F PBlack 5
        DDiese HalfNote 5
        F PBlack 5
        DDiese HalfNote 5
        D White 5
        DDiese White 5
        F White 5
        G White 5
        D PWhite 5
        D Black 5
        DDiese PWhite 5 
        G HalfNote 5
        A HalfNote 5
        ADiese White 5
        A White 5
        G PWhite 5
        G HalfNote 5
        A HalfNote 5
        ADiese White 5
        A Black 5
        C Black 6
        D Round 6
        F PWhite 6
        Sil Silence 6
        F FifthNote 4
        G FifthNote 4
        A FifthNote 4
        ADiese FifthNote 4
        C FifthNote 5
        D Round 5
        Sil Silence 5
        F FifthNote 4
        G FifthNote 4
        A FifthNote 4
        ADiese FifthNote 4
        C FifthNote 5
        D PWhite 5
        G HalfNote 4
        A HalfNote 4
        ADiese PHalfNote 4
        ADiese QuarterNote 4
        HalfSil HalfSilence 4
        C HalfNote 5
        D HalfNote 5
        C HalfNote 5
        ADiese HalfNote 4
        A HalfNote 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4

        // 4th page 3:25
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C Black 5
        ADiese HalfNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        A QuarterNote 4
        G QuarterNote 4
        D PWhite 4
        A QuarterNote 5
        ADiese QuarterNote 5
        A QuarterNote 5
        G QuarterNote 5
        D PWhite 5
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C HalfNote 5
        ADiese HalfNote 4
        D Round 5
        Sil Silence 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C HalfNote 5
        ADiese HalfNote 4
        D Round 5     // 3:40   87
        Sil Silence 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese White 4
        G PHalfNote 4
        A QuarterNote 4
        HalfSil HalfSilence 4
        ADiese Black 4
        C Black 5
        ADiese HalfNote 4
        A QuarterNote 4
        ADiese QuarterNote 4
        A QuarterNote 4
        G QuarterNote 4
        D PWhite 4
        A QuarterNote 5
        ADiese QuarterNote 5
        A QuarterNote 5
        G QuarterNote 5
        D Black 5  //3:48
        Sil Silence 5
        F QuarterNote 5
        C QuarterNote 5
        D QuarterNote 5
        F QuarterNote 5
        G PHalfNote 5
        G QuarterNote 5
        HalfSil HalfSilence 5
        G HalfNote 5
        F PHalfNote 5
        F QuarterNote 5
        HalfSil HalfSilence 5
        D QuarterNote 5
        F QuarterNote 5
        G PHalfNote 5
        G QuarterNote 5
        HalfSil HalfSilence 5
        G HalfNote 5
        A HalfNote 5
        HalfSil HalfSilence 5
        D HalfNote 5
        HalfSil HalfSilence 5
        C Black 4
        C Black 4
        C Black 4    // 3:54
        Sil Silence 5
        A PBlack 5
        G HalfNote 5
        A HalfNote 5
        ADiese HalfNote 5
        C HalfNote 6
        D HalfNote 6
        F PBlack 6
        DDiese HalfNote 6
        ADiese White 5
        DDiese PBlack 6
        D HalfNote 6
        A White 5
        C PBlack 6
        ADiese HalfNote 5
        A HalfNote 5
        ADiese HalfNote 5
        C HalfNote 6
        D HalfNote 6
        G Round 6

        // 5th page 
        G White 5
        A White 5
        A PBlack 5
        ADiese HalfNote 5
        ADiese White 5
        DDiese Black 4
        G Black 4
        FDiese HalfNote 4
        G HalfNote 4
        A HalfNote 4
        ADiese HalfNote 4
        A PBlack 4
        G HalfNote 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        F PBlack 5
        DDiese HalfNote 5
        ADiese White 4
        DDiese PBlack 5
        D HalfNote 5
        A White 4
        C PBlack 5
        ADiese HalfNote 4
        A HalfNote 4
        ADiese HalfNote 4
        C HalfNote 5
        D HalfNote 5
        G Round 5
        G White 4
        A White 4
        G Round 4
        G Round 4

        |]


    let SongAssemble (song: byte [][] ) = //add delay between each note to hear if same notre is following and concat them into array of byte array
            let mutable wave2 = sinbyte 0. 0.
            for j in 0..song.Length-1 do
                let delay = Array.init (int(sampleRate/1000.)) (fun i -> 0. |> sample)
                wave2 <- Array.concat[|wave2; delay; song.[j]|]
            wave2