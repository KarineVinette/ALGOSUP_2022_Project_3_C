namespace SyntheAudio

module Note =
    open System
    open XPlot.GoogleCharts
    open SFML.Audio

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

    let NotesValues note  = 
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
