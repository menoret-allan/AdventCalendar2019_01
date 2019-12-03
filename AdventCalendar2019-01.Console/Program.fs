// Learn more about F# at http://fsharp.org

open AdventCalendar2019_01.Core.SpaceUtils

[<EntryPoint>]
let main argv =
    let result =
        System.IO.File.ReadLines("input.txt")
        |> Seq.map(int)
        |> Seq.sumBy CalculateFullRequire
    printfn "result: %i" result
    0 // return an integer exit code
