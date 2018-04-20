open System

[<EntryPoint>]
let main argv =
    printfn "Insert uncancerous string:"
    Console.ReadLine() |> CancerString.StringToCancer.create |> printfn "%s" 
    printfn "Press <ENTER> to close"
    System.Console.ReadLine() |> ignore
    0 
