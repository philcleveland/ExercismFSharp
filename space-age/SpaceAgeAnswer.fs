module SpaceAge

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
    0m