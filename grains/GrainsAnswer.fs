module Grains
open System.Numerics

let square x = BigInteger.Pow(2I, x - 1)
let total = [for i in 1..64 -> square i] |> Seq.sum
     
    
    