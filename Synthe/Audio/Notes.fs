namespace SyntheAudio
open System
open Waves

module Note =

    type Length = 
        | HalfSilence
        | Silence
        | MSilence
        | EightNote
        | QuarterNote
        | HalfNote
        | Black
        | White
        | Round

    let getFreq freq octave =
        match octave with
        | 0 -> freq / 16.
        | 1 -> freq / 8.
        | 2 -> freq / 4.
        | 3 -> freq / 2.
        | 4 -> freq
        | 5 -> freq * 2.
        | 6 -> freq * 4.
        | 7 -> freq * 8.
        | 8 -> freq * 16.
        | _ -> 0.

    let getLength (length:Length) =
        match length with 
        | HalfSilence -> 0.25
        | Silence -> 1.
        | MSilence -> 4.
        | HalfNote -> 0.5
        | QuarterNote -> 0.25
        | EightNote -> 0.125
        | Black -> 1.
        | White -> 2.
        | Round -> 4.

    let HalfSil (length:Length) (octave:int) =
        let NoteFreq = getFreq 0. octave
        let NoteLength = getLength length
        sinbyte NoteLength NoteFreq

    let Sil (length:Length) (octave:int) =
        let NoteFreq = getFreq 0. octave
        let NoteLength = getLength length
        sinbyte NoteLength NoteFreq

    let MSil (length:Length) (octave:int) =
        let NoteFreq = getFreq 0. octave
        let NoteLength = getLength length
        sinbyte NoteLength NoteFreq

    let A (length:Length) (octave:int) =
        let NoteFreq = getFreq 440. octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let ADiese (length:Length) (octave:int) =
        let NoteFreq = getFreq 466.164 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let B (length:Length) (octave:int) =
        let NoteFreq = getFreq 493.883 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let C (length:Length) (octave:int) =
        let NoteFreq = getFreq 261.626 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let CDiese (length:Length) (octave:int) =
        let NoteFreq = getFreq 277.183 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let D (length:Length) (octave:int) =
        let NoteFreq = getFreq 293.665 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let DDiese (length:Length) (octave:int) =
        let NoteFreq = getFreq 311.127 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let E (length:Length) (octave:int) =
        let NoteFreq = getFreq 329.628 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let F (length:Length) (octave:int) =
        let NoteFreq = getFreq 349.228 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let FDiese (length:Length) (octave:int) =
        let NoteFreq = getFreq 369.994 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let G (length:Length) (octave:int) =
        let NoteFreq = getFreq 391.995 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    let GDiese (length:Length) (octave:int) =
        let NoteFreq = getFreq 415.305 octave
        let NoteLength = getLength length 
        sinbyte NoteLength NoteFreq

    // type Note  =
    //     | A
    //     | ADiese
    //     | B
    //     | C
    //     | CDiese
    //     | D
    //     | DDiese
    //     | E
    //     | F
    //     | FDiese
    //     | G
    //     | GDiese

    // type Length = 
    //     | EightNote
    //     | QuarterNote
    //     | HalfNote
    //     | Black
    //     | White
    //     | Round

    // let NotesValues (lenght:Length) (note:Note) (octave:int) = 

    //     let noteFrequenceWithoutOctave =
    //         match note with
    //         | A -> 440.
    //         | ADiese -> 466.164
    //         | B -> 493.883
    //         | C -> 261.626
    //         | CDiese -> 277.183 
    //         | D -> 293.665
    //         | DDiese -> 311.127
    //         | E -> 329.628
    //         | F -> 349.228
    //         | FDiese -> 369.994
    //         | G -> 391.995
    //         | GDiese -> 415.305

    //     match octave with 
    //     | 0 -> noteFrequenceWithoutOctave / 16.
    //     | 1 -> noteFrequenceWithoutOctave / 8.
    //     | 2 -> noteFrequenceWithoutOctave / 4.
    //     | 3 -> noteFrequenceWithoutOctave / 2.
    //     | 4 -> noteFrequenceWithoutOctave
    //     | 5 -> noteFrequenceWithoutOctave * 2.
    //     | 6 -> noteFrequenceWithoutOctave * 4.
    //     | 7 -> noteFrequenceWithoutOctave * 8.
    //     | 8 -> noteFrequenceWithoutOctave * 16.
    //     | _ -> 0. // We should be able to catch an error and print that we are not playing a sound because the octave is wrong

    // let NoteLength (length:Length) =

    //     match length with 
    //     | HalfNote -> 0.5
    //     | QuarterNote -> 0.25
    //     | EightNote -> 0.125
    //     | Black -> 1
    //     | White -> 2
    //     | Round -> 4