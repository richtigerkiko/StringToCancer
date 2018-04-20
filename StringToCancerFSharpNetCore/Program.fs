open System

let StringToCancer notCancerYet =
    let mutable cancerString = ""
    let mutable i = ref 0
    for c in notCancerYet do
        if Char.IsWhiteSpace(c) then incr i
        if i.Value % 2 = 0 then cancerString <- cancerString + c.ToString().ToUpper()
        else cancerString <- cancerString + c.ToString().ToLower()
        incr i
    cancerString

[<EntryPoint>]
let main argv =
    printfn "Insert uncancerous string:"
    Console.ReadLine() |> StringToCancer |> printfn "%s" 
    printfn "Press <ENTER> to close"
    System.Console.ReadLine() |> ignore
    0 
