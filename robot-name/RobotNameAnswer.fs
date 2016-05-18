module RobotName
open System
open System.Text

type Robot() =
    //digit 48-57
    //uppercase letter 65-90
    //lowercase letter 97-122 Not going to use these because my robots are only caps
    //namePattern = @"\w{2}\d{3}" e.g. AB123 or xY456
    
    let createName() =
        let rand = new System.Random((int)DateTime.Now.Ticks)
        ([for i in 1..2 do yield char(rand.Next(65, 90)) |> Char.ToString] |> String.concat "") + 
        rand.Next(100, 999).ToString()
    
    let originalName = createName()     
    
    let mutable name = originalName
    member this.Name = name
    member this.Reset() = name <- createName() 