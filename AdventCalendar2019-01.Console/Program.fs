open AdventCalendar2019_01.Core.SpaceUtils

[<EntryPoint>]
let main argv =
    let result =
        System.IO.File.ReadLines("input.txt")
        |> Seq.map(int)
        |> Seq.sumBy CalculateFullRequire
    printfn "result part 1: %i" result
    let result =
        System.IO.File.ReadLines("input.txt")
        |> Seq.map(int)
        |> Seq.sumBy CalculateFullRequirePart2
    printfn "result part 2: %i" result
    0 // return an integer exit code
