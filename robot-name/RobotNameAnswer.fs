module RobotName
open System
type Robot() =
    //digit 48-57
    //uppercase letter 65-90
    //lowercase letter 97-122 Not going to use these because my robots are only caps
    //namePattern = @"\w{2}\d{3}" e.g. AB123 or xY456
    
    let createName() =
        let rand = new System.Random((int)DateTime.Now.Ticks)
        ([for i in 1..2 do yield rand.Next(65, 90) |> Convert.ToChar |> Char.ToString] |> String.concat "") + 
        ([for i in 1..3 do yield rand.Next(48, 57) |> Convert.ToChar |> Char.ToString] |> String.concat "")
    
    let originalName = createName()     
    
    let mutable name = originalName
    member this.Name = name
    member this.Reset() = name <- createName() 