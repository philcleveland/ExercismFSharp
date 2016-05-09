module Bob
open System

let isQuestion (s:string) = 
    (s.EndsWith("?") && (Seq.exists(fun c-> Char.IsLower(c)) s = true || Seq.exists(fun c-> Char.IsLetter(c)) s = false))

let isYelling (s:string) =
    Seq.exists(fun c-> Char.IsLower(c)) s = false || s.EndsWith("!")

let isAllNumbers (s:string) =
    Seq.exists(fun c-> Char.IsLetter(c)) s = false

let hey s =
    match s with
    | s when String.IsNullOrWhiteSpace(s) -> sprintf "Fine. Be that way!"
    | _ -> 
        match s with
        | s when isQuestion s -> sprintf "Sure."
        | s when isAllNumbers s -> sprintf "Whatever."
        | s when isYelling s -> sprintf "Whoa, chill out!"
        | _ -> sprintf "Whatever."
    