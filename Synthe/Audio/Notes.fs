namespace SyntheAudio

module Note =
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
            | ADiese -> 466.16
            | B -> 493.88
            | C -> 261.63
            | CDiese -> 277.18 
            | D -> 293.66
            | DDiese -> 311.13
            | E -> 329.63
            | F -> 349.23
            | FDiese -> 369.99
            | G -> 392.
            | GDiese -> 415.31

        match octave with 
        | 0 -> noteFrequenceWithoutOctave / 16
        | 1 -> noteFrequenceWithoutOctave / 8
        | 2 -> noteFrequenceWithoutOctave / 4
        | 3 -> noteFrequenceWithoutOctave / 2
        | 4 -> noteFrequenceWithoutOctave
        | 5 -> noteFrequenceWithoutOctave * 2
        | 6 -> noteFrequenceWithoutOctave * 4
        | 7 -> noteFrequenceWithoutOctave * 8
        | 8 -> noteFrequenceWithoutOctave * 16
