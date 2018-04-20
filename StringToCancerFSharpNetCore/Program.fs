open System

let StringToCancer notCancerYet =

    let mutable cancerString = ""
    let mutable i = 0
    for c in notCancerYet do
        match Char.IsWhiteSpace(c) with
            | true ->
                i <- i + 1
                cancerString <- cancerString + c.ToString()
            | false ->
                match i % 2 with
                    | 0 -> cancerString <- cancerString + c.ToString().ToUpper()

                    | 1 -> cancerString <- cancerString + c.ToString().ToLower()

        i <- i + 1
    cancerString

module Seq =
    let infiniteRepeat items =
        seq { while true do yield! items }


[<EntryPoint>]
let main argv =

    printfn "Insert uncancerous string:"
    let str = StringToCancer(Console.ReadLine())
    printfn "%s" str
    printfn "Press <ENTER> to close"
    System.Console.ReadLine() |> ignore
    0 
