module Note

    open System

    type Note  =
        | A
        | ADiese
        | B
        | C
        | CDiese
        | D
        | DDiese
        | E
        | F
        | FDiese
        | G
        | GDiese

    let NotesValues (note:Note) (octave:int)  = 
        let noteFrequenceWithoutOctave =
            match note with
            | A -> 440.
            | ADiese -> 466.164
            | B -> 493.883
            | C -> 261.626
            | CDiese -> 277.183 
            | D -> 293.665
            | DDiese -> 311.127
            | E -> 329.628
            | F -> 349.228
            | FDiese -> 369.994
            | G -> 391.995
            | GDiese -> 415.305

        match octave with 
        | 0 -> noteFrequenceWithoutOctave / 16.
        | 1 -> noteFrequenceWithoutOctave / 8.
        | 2 -> noteFrequenceWithoutOctave / 4.
        | 3 -> noteFrequenceWithoutOctave / 2.
        | 4 -> noteFrequenceWithoutOctave
        | 5 -> noteFrequenceWithoutOctave * 2.
        | 6 -> noteFrequenceWithoutOctave * 4.
        | 7 -> noteFrequenceWithoutOctave * 8.
        | 8 -> noteFrequenceWithoutOctave * 16.
        | _ -> 0
