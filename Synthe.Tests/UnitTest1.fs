namespace SyntheAudio

open NUnit.Framework
open Waves 
open Effect

module Test = 

    [<SetUp>]
    let Setup () =
        ()

    [<Test>]
    let sineWave() =
        let result = sinWave.Length
        Assert.AreEqual(limit, result)
    [<Test>]
    let triangle() =
        let result = triangleWave.Length
        Assert.AreEqual(limit, result)

    [<Test>]
    let squarre() =
        let result = squareWave.Length
        Assert.AreEqual(limit, result)

    [<Test>]
    let Sawtooth() =
        let result = sawWave.Length
        Assert.AreEqual(limit, result)

    [<Test>]
    let Overdrive() =
        let mutable result = 0
        let wave = Overdrive 0.7 sinWave 
        for i in 0..limit-1 do
            if wave.[i] > 0.7 || wave.[i] < -0.7 then
                result <- result + 1
        Assert.AreEqual(0, result)
