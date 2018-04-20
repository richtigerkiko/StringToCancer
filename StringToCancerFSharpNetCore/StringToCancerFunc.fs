namespace CancerString
open System

module StringToCancer = 
    type T = {NotCancerYet:string} 
    let create notCancerYet =
        let mutable cancerString = ""
        let mutable i = ref 0
        for c in notCancerYet do
            if Char.IsWhiteSpace(c) then incr i
            if i.Value % 2 = 0 then cancerString <- cancerString + c.ToString().ToUpper()
            else cancerString <- cancerString + c.ToString().ToLower()
            incr i
        cancerString
