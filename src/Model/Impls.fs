namespace Replay

open Replay.Model.Types

module Model =

    module Publisher =
        let create id name = { id = id; name = name }

    module Title =
        let create id name publisher = { id = id; name = name; publisher = publisher }