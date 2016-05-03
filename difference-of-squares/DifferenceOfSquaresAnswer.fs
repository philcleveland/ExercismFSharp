module DifferenceOfSquares

let squareOfSums x =
    let sum = [0..x] |> Seq.sum
    sum*sum
    
    
let sumOfSquares x =
    [0..x] |> Seq.sumBy(fun x-> x*x)
    
let difference x =
    squareOfSums x - sumOfSquares x