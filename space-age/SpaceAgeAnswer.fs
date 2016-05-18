module SpaceAge
open System

let EarthYear = 31557600m
let MercuryYear = EarthYear * 0.2408467m
let VenusYear = EarthYear * 0.61519726m
let MarsYear = EarthYear * 1.8808158m
let JupiterYear = EarthYear * 11.862615m
let SaturnYear = EarthYear * 29.447498m
let UranusYear = EarthYear * 84.016846m
let NeptuneYear = EarthYear * 164.79132m

type Planet =
    | Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune
    
let spaceAge (p) (age:decimal) =
    let coef = match p with
               | Earth -> EarthYear
               | Mercury ->MercuryYear
               | Venus -> VenusYear
               | Mars -> MarsYear
               | Jupiter -> JupiterYear
               | Saturn -> SaturnYear
               | Uranus -> UranusYear
               | Neptune -> NeptuneYear
    Math.Round(age / coef, 2)