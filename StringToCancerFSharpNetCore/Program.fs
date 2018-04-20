open System

let StringToCancer notCancerYet =
    let mutable cancerString = ""
    let mutable i = ref 0
    for c in notCancerYet do
        match Char.IsWhiteSpace(c) with
            | true ->
                incr i
                cancerString <- cancerString + c.ToString()
            | false ->
                match i.Value % 2 with
                    | 0 -> cancerString <- cancerString + c.ToString().ToUpper()
                    | 1 -> cancerString <- cancerString + c.ToString().ToLower()
        incr i
    cancerString

[<EntryPoint>]
let main argv =
    printfn "Insert uncancerous string:"
    Console.ReadLine() |> StringToCancer |> printfn "%s" 
    printfn "Press <ENTER> to close"
    System.Console.ReadLine() |> ignore
    0 
