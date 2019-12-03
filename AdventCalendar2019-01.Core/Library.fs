namespace AdventCalendar2019_01.Core

module SpaceUtils =
    let CalculateFullRequire mass =
        mass / 3 - 2

    let rec CalculateFullRequirePart2 mass =
        match mass / 3 - 2 with
        | 0 | -1 | -2 -> 0
        | x -> CalculateFullRequirePart2 x + x
