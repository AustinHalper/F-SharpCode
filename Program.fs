// Learn more about F# at http://fsharp.org
// Austin Halper
open System

let mutable ok = true
while ok do
    Console.WriteLine("Choose an operation: \n1.Addtion\n2.Subtraction\n3.Multiplication\n4.Division\n5.Modulo\n6.Select All")
    let input = Console.ReadLine()
    Console.WriteLine("Ok, now type in 2 numbers")
    let a = Console.ReadLine()
    let b = Console.ReadLine()
    let A : int = int32 a
    let B : int = int32 b
    (*---------Functions---------*)
    let add x y = x + y
    let sub x y = x - y
    let mul x y = x * y
    let div x y = x / y
    let MOD x y = x % y
    (*----------------------------*)
    let selall() =
        printfn("1. The Result is %d") (add A B)
        printfn("2. The Result is %d") (sub A B)
        printfn("3. The Result is %d") (mul A B)
        printfn("4. The Result is %d") (div A B)
        printfn("5. The Result is %d") (MOD A B)
    (*-----------------------------*)
    match input with 
    | "1" -> printfn("The Result is %d") (add A B)
    | "2" -> printfn("The Result is %d") (sub A B)
    | "3" -> printfn("The Result is %d") (mul A B)
    | "4" -> printfn("The Result is %d") (div A B)
    | "5" -> printfn("The Result is %d") (MOD A B)
    | "6" -> selall()
    | _ -> printfn("Choose between 1 and 6!!!!")
    Console.WriteLine("Would you like to use the calculator again? y/n")
    let ans = Console.ReadLine()
    if ans = "n" then 
        ok <- false
    else Console.Clear()
