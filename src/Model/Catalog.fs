namespace Replay

open Replay.Model.Types

module Model = 

    module Title =
        let create id name publisher = { id = id; name = name; publisher = publisher }