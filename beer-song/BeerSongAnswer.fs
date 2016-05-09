module BeerSong
open System
let verse (x:int) = 
    match x with
    | 0 -> sprintf "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n"
    | 1 -> sprintf "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n"
    | 2 -> sprintf "2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n" 
    | _ -> String.Format("{0} bottles of beer on the wall, {0} bottles of beer.\nTake one down and pass it around, {1} bottles of beer on the wall.\n", x, (x-1))
    
let verses (start:int) (stop:int) : string =
    seq {stop..start}
        |> Seq.rev
        |> Seq.map(fun i -> sprintf "%s\n" (verse i))
        |> Seq.fold(fun state v-> state + v) ""
    
let sing =
    verses 99 0