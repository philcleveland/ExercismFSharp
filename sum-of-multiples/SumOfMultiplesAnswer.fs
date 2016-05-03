module SumOfMultiples

let isDivisibleBy divisors value =
    divisors |> List.exists(fun div -> value % div = 0)    
        
let sumOfMultiples (vals:seq<int>) (max:int) =
    [0..max-1]
    |> Seq.filter (isDivisibleBy (vals |> Seq.toList))
    |> Seq.sum
    