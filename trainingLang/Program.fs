open System

let peopleArray =
    [| "Jon"
       "Gustavo"
       "Gabriel"
       "Jonas"
       "" |]

let isValid person = String.IsNullOrWhiteSpace person |> not

let isAllowed person = person <> "Gustavo"

let sayHello person = printfn "Opa, salve salve %s" person

[<EntryPoint>]
let main argv =
    peopleArray
    |> Array.filter isValid
    |> Array.filter isAllowed
    |> Array.iter sayHello
    printfn "Bom conhecer oceis"


    0
