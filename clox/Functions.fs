﻿module Functions
//in the equation t = b / (x - y)
//t represents the amount of time (in minutes) it will take for 
//the hands of a clock to form the given angle b
//x = the number of degrees the faster hand moves per second
//y = the number of degrees the slower hand moves per second
//
//this is encapsulated in the function capculateT(b, x, y)
let calculateT b x y = b/(x - y) * 1.0

let getMinutes hrs = hrs * 60.0

let count m fn b1 b2 x y = 
    (m / ((fn b1 x y) - (fn b2 x y))) * 1.0

let calculate m fn2 b1 b2 x1 x2 y1 = 
    let c1 = count m fn2 b1 b2 x1 x2
    let c2 = count m fn2 b1 b2 x1 y1
    let c3 = count m fn2 b1 b2 x2 y1
    (c1 + c2 + c3) * 1.0