[<EntryPoint>]
let main argv =
    let mutable person = "Person"
    if argv.Length > 0 then
        // <- é igual ao = só que para mutable
        person <- argv.[0]
    printfn "Simple print line %s" person
    0 // return an integer exit code
