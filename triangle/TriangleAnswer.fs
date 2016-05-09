module Triangle
open System
type TriangleKind =
    Scalene
    | Isosceles
    | Equilateral
   
let kind (a:decimal) (b:decimal) (c:decimal) : TriangleKind =
    if a + b <= c || 
       a + c <= b || 
       b + c <= a || 
       (a=0m || b=0m || c=0m) then raise (new InvalidOperationException())
    
    if a = b && b = c then 
        TriangleKind.Equilateral
    else if a = b || a = c || b = c then
        TriangleKind.Isosceles
    else
        TriangleKind.Scalene