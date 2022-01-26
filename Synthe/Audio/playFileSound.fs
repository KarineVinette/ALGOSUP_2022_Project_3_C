module playSynth
open System
open System.Threading
open SFML.Audio 



let PlaySound (url:string) = //Allow to choose your file
    let buffer = new SoundBuffer(url) //Storage for audio sample defining a sound
    let sound = new Sound(buffer) 
    sound.Play() 

    while sound.Status = SoundStatus.Playing do
        Thread.Sleep(100)

// let play = PlaySound @"../../../createdSound/test1.wav"

    