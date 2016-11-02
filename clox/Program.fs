// Learn more about F# at http://fsharp.org
open System
open Functions


let minutes = getMinutes 24.0
let answer = calculate minutes calculateT 270.0 90.0 360.0 6.0 0.5
printfn "# of right angles in 24 hours = %f" answer

[<EntryPoint>]
let main argv = 
    0 // return an integer exit code