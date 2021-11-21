namespace FSharpProject

open System.IO
open System

module FSharpModule =

    type Order = { Id: int }

    let logToConsole msg =
        printfn "%s" msg
    let logToFile msg filename =
        printfn "Logging to %s: %s" filename msg
        File.AppendAllText (filename, msg + Environment.NewLine)
    let processOrderAndLog order log =
        sprintf  "About to process order %i" order.Id |> log
        printfn "Actually processing order %i" order.Id
        sprintf "Done processing order %i" order.Id |> log
        