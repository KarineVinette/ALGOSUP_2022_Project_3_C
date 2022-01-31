namespace SyntheAudio
open Waves

module Note =

    type Length = 
        | HalfSil
        | Sil
        | MSil
        | EightNote
        | QuarterNote
        | Triolet
        | HalfNote
        | PHalfNote
        | Black
        | PBlack
        | White
        | PWhite
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
        | HalfSil -> 0.5
        | Sil -> 1.
        | MSil -> 4.
        | HalfNote -> 0.5
        | PHalfNote -> 0.75
        | Triolet -> 0.33
        | QuarterNote -> 0.25
        | EightNote -> 0.125
        | Black -> 1.
        | PBlack -> 1.5
        | White -> 2.
        | PWhite -> 2.5
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

    let Silence (length:Length) =
        let SilenceLength = getLength length
        sinbyte SilenceLength 0.