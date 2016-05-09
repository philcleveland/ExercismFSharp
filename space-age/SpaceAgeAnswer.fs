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
    Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune
    
let spaceAge (p:Planet) (age:decimal) =
    match p with
    | Planet.Earth -> Math.Round(age / EarthYear, 2)
    | Planet.Mercury -> Math.Round(age / MercuryYear, 2)
    | Planet.Venus -> Math.Round(age / VenusYear, 2)
    | Planet.Mars -> Math.Round(age / MarsYear, 2)
    | Planet.Jupiter -> Math.Round(age / JupiterYear, 2)
    | Planet.Saturn -> Math.Round(age / SaturnYear, 2)
    | Planet.Uranus -> Math.Round(age / UranusYear, 2)
    | Planet.Neptune -> Math.Round(age / NeptuneYear, 2)