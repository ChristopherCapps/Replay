module Engine

open Fake.Core

type EngineResult = 
    | EngineFailure of exitCode: int * errorMessage: string
    | EngineSuccess of output: string * error: string


let run (exePath:string) (args:string seq) =
    let result = 
        CreateProcess.fromRawCommand exePath args
        |> CreateProcess.redirectOutput
        |> Proc.run

    match result.ExitCode with
    | 0 -> 
        EngineSuccess(result.Result.Output, result.Result.Error)
    | error -> 
        EngineFailure(error, result.Result.Error)
