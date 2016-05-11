module BeerSong
open System
let verse (x:int) = 
    match x with
    | 0 -> sprintf "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.\n"
    | 1 -> sprintf "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n"
    | 2 -> sprintf "2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n" 
    | _ -> String.Format("{0} bottles of beer on the wall, {0} bottles of beer.\nTake one down and pass it around, {1} bottles of beer on the wall.\n", x, (x-1))
    
let verses (start:int) (stop:int) : string =
    seq {start .. -1 .. stop}
        |> Seq.map verse
        |> String.concat "\n"
        |> sprintf "%s\n" //need this because ``Test several verses`` expects an additional \n at the end that concat doesnt provide.
    
let sing =
    verses 99 0