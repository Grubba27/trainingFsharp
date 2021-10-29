[<EntryPoint>]
let main argv =
    let person =
        if argv.Length > 0 then
            argv.[0]
        else
            "Anon Person"

    printfn "Simple print line %s" person
    0 // return an integer exit code
