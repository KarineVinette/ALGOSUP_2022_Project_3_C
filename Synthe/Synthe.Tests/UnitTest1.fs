module Synthe.tests

open NUnit.Framework
open Undertone

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Wavesine() =
    let result = Creation.sine 49.9
    Assert.Equals(43.432432432342, result)
