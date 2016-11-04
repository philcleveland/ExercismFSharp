module Bowling
    let newGame = []

    //note that the game rolls are returned in reverse order
    let roll (pins) (game) = pins::game
    let score game =
      let rec calcScore (line:List<int>) score =
        match line with
        | 10::x::y::[] -> score + 10 + x + y //strike in 10th
        | 10::x::y::tail -> calcScore (x::y::tail) score + 10 + x + y //strike
        | x::y::z::tail when x + y = 10 -> calcScore (z::tail) score + 10 + z //spare
        | x::y::tail -> calcScore (tail) score + x + y
        | _ -> score
      calcScore (game |> List.rev) 0 