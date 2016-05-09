module Gigasecond

open System

let gS = 10.0**9.0

let gigasecond (bDay:DateTime) =
    bDay.AddSeconds(gS).Date
    