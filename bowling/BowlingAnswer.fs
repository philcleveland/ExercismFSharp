module Bowling
    let newGame = []

    let strikeScore x y = 10 + x + y
    let spareScore x = 10 + x
    let openFrameScore x y = x + y
    //note that the game rolls are returned in reverse order
    let roll (pins) (game) = pins::game
    let score game =
      //note that by using a Pattern Matching Function here 
      //it is implicit that the calcScore function takes a curried list int
      //use a pattern matching function when the match x with is the entirety
      //of the function.
      let rec calcScore curScore = function 
        | 10::x::y::[] -> curScore + strikeScore x y
        | 10::x::y::tail -> calcScore (curScore + strikeScore x y) (x::y::tail)
        | x::y::z::tail when x + y = 10 -> calcScore (curScore + spareScore z) (z::tail)
        | x::y::tail -> calcScore (curScore + openFrameScore x y) (tail) 
        | _ -> curScore
      game |> List.rev |> calcScore  0