// Learn more about F# at http://fsharp.org

[<EntryPoint>]
let main argv =
    //Replay.Engines.ScummVM.run |> ignore
    let results = CLI.parser.Parse argv
    printfn "%A" (CLI.parser.PrintUsage())
    printfn "%A" results
    //printfn "%s" (serialize [settings; settings; settings])
    // if Array.length argv < 1 then failwith "A path or filename must be provided."
    // queryMediaTags (NamedTags (Array.tail argv)) argv.[0]
    // |> printResults
    0