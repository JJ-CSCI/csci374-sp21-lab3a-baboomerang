module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
    (v : float) * 25.4

let footToInch x =
    (x : float) * float 12

let yardToFoot v = 
    (v : float) * float 3

let mileToYard mile = 
    (mile : float) * float 1760

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
    yardToFoot y |> footToInch |> inchToMillimeter

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
  fun x->(x : float)/float 1000

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    0.0 // write your code here

let meterToKilometer =
    fun x->x // write your code here

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    fun x->x // write your code here

let inchToMeter =
    fun x->x // write your code here

let yardToKilometer =
    fun x->x // write your code here

let mileToMeter =
    fun x->x // write your code here


// Define following weight unit transformations
let ounceToGram v =
    (v : float) * float 28.349523125

let poundToOunce p =
    (p : float) * float 16

let shortTonToPound t =
    (t : float) * float 2000


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    0.0

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    fun x->x // write your code here

let poundToKilogram =
    fun x->x // write your code here

let shortTonToMetricTon =
    fun x->x // write your code here
