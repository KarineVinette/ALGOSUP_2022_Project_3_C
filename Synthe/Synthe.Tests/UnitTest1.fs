module Synthe.tests

open Program
open NUnit.Framework
<<<<<<< Updated upstream
=======
open waves
open playSynth
>>>>>>> Stashed changes


[<SetUp>]
let Setup () =
    ()

<<<<<<< Updated upstream
//[<Test>]
//let sineWave =
//    let result = waves.sinWave 44100. 22. 432.
//    Assert.Equals(43.432432432342, result)
=======
[<Test>]
let sineWave() =
   let result = sinWave
   Assert.AreEqual(null , result)

[<Test>]
let triangle() =
   let result = triangle
   Assert.AreEqual(null , result)

[<Test>]
let squarre() =
   let result = squareWave
   Assert.AreEqual(null , result)

[<Test>]
let Sawtooth() =
   let result = sawWave
   Assert.AreEqual(null , result)

[<Test>]
let playSound() =
   let result =
        match play with
        | 0 -> false
        | 1 -> true
   Assert.AreEqual(true , result)
>>>>>>> Stashed changes
