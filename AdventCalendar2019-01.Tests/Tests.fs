module Tests

open System
open Xunit
open FsUnit
open AdventCalendar2019_01.Core.SpaceUtils

[<Theory>]
[<InlineData(12, 2)>]
[<InlineData(14, 2)>]
[<InlineData(1969, 654)>]
[<InlineData(100756, 33583)>]
let ``Full calculator`` (mass, expectedFull) =
    mass |> CalculateFullRequire |> should equal expectedFull
