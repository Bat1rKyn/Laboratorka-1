open System

////Задача 1

//let cheack number = 
//    [
//    for i in 1.. number do
//        printf "Enter number "
//        let number = int(Console.ReadLine())
//        if (number % 2) = 0
//        then yield "true"
//        else yield "false"
//    ]
//[<EntryPoint>]
//let main args = 
//    printfn "Enter col number"
//    let number = int(Console.ReadLine())
//    printfn "Spisok:  %A" (cheack number)
//    0


 //Задача 2
let rec del number =
    [
        if number < 10 then 
            yield number
        else
            let lastnumber = number % 10
            let ostnumber = del (number / 10)
            yield! ostnumber
            yield lastnumber
    ]

[<EntryPoint>]
let main args = 
    printfn "Enter number:"
    let number = int(Console.ReadLine())
    printfn "Spisok: %A" (del number)
    0