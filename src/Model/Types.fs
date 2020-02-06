namespace Replay.Model

module Types =

    type Publisher = {
        id: string
        name: string
    }

    type Title = {
        id: string
        name: string
        publisher: Publisher option
    }

