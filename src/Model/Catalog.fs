namespace Replay

open Replay.Model.Types
open Replay.Model

module Catalog =

    module Publishers =

        let publishers = [
            Publisher.create "sierra" "Sierra On-line"
            Publisher.create "infocom" "Infocom"
        ]

        let publisherWithId (publishers:Publisher list) id =
            publishers |> List.tryFind (fun p -> p.id = id)

        let sierra = publisherWithId publishers "sierra"


    let titles = [
        Title.create "kq1agi" "King's Quest I: Quest for the Throne (AGI)" Publishers.sierra
        Title.create "kq1sci" "King's Quest I: Quest for the Throne (SCI)" Publishers.sierra
    ]