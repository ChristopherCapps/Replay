namespace Replay.Engines

module ScummVM =
    module Model =
        open Replay.Model

        type AudioOption =
            | PC
            | PCjr
            | Tandy
            | MT32

        type VideoOption =
            | CGA
            | EGA
            | Tandy
            | VGA
            | Hercules

        type Option = 
            | Audio of AudioOption
            | Video of VideoOption

        type Game = {
            game: Game
            path: string
            options: Option list
        }

    open Engine

    let Path = "engines/scummvm/ScummVM.app/Contents/MacOS/scummvm"

    let run = 
        Engine.run Path (seq { "-h" })