namespace SyntheAudio

open NUnit.Framework
open Waves 
open Effect
open Song

module Test = 

                [<SetUp>]
                let Setup () =
                    ()

                [<Test>]
                let SineWave() =
                    let result = sinWave.Length
                    Assert.AreEqual(limit, result)

                [<Test>]
                let TriangleWave() =
                    let result = triangleWave.Length
                    Assert.AreEqual(limit, result)

                [<Test>]
                let SquareWave() =
                    let result = squareWave.Length
                    Assert.AreEqual(limit, result)

                [<Test>]
                let SawtoothWave() =
                    let result = sawWave.Length
                    Assert.AreEqual(limit, result)

                [<Test>]
                let numbSong()=
                    let result = Numb.Length
                    Assert.AreEqual(353, result)

                [<Test>]
                let InTheEndSong()=
                    let result = InTheEnd.Length
                    Assert.AreEqual(370, result)

                [<Test>]
                let GoldenWindSong()=
                    let result = GoldenWind.Length
                    Assert.AreEqual(129, result)

                [<Test>]
                let SolviegSong()=
                    let result = Solvieg.Length
                    Assert.AreEqual(22, result)

                [<Test>]
                let SusSong()=
                    let result = Amogus.Length
                    Assert.AreEqual(11, result)

                [<Test>]
                let KalinkaSong()=
                    let result = Kalinka.Length
                    Assert.AreEqual(152, result)

                [<Test>]
                let RRSong()=
                    let result = RR.Length
                    Assert.AreEqual(35, result)

                [<Test>]
                let MegalovaniaSong()=
                    let result = Megalovania.Length
                    Assert.AreEqual(52, result)

                [<Test>]
                let TOMSong()=
                    let result = TOM.Length
                    Assert.AreEqual(141, result)

                [<Test>]
                let ZeldaOverworldSong()=
                    let result = ZeldaOverworld.Length
                    Assert.AreEqual(135, result)

                [<Test>]
                let CrazySong()=
                    let result = Crazy.Length
                    Assert.AreEqual(97, result)

                [<Test>]
                let LacSong()=
                    let result = Lac.Length
                    Assert.AreEqual(84, result)

                [<Test>]
                let GadjetSong()=
                    let result = Gadjet.Length
                    Assert.AreEqual(47, result)

                [<Test>]
                let UnravelSong()=
                    let result = Unravel.Length
                    Assert.AreEqual(15, result)

                [<Test>]
                let LVERSong()=
                    let result = LVER.Length
                    Assert.AreEqual(71, result)

                [<Test>]
                let LettreAEliseSong()=
                    let result = LettreAElise.Length
                    Assert.AreEqual(40, result)