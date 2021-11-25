//This code is based on code obtained from fsharpforfunandprofit.com
//The license of code obtained from fsharpforfunandprofit.com can be found at https://fsharpforfunandprofit.com/about/license/
// and a copy of it is also included in LICENSE.fsharpforfunandprofit.txt in this repo
namespace FSharpProject

module FSharpModule =

    type ComparisonResult =
        | Bigger
        | Smaller
        | Equal

    let askUserForStrings readLn writeLn =
        writeLn "Enter the first value"
        let str1 = readLn()
        writeLn "Enter the second value"
        let str2 = readLn()
        (str1, str2)

    let compareTwoStrings str1 str2 log =
        log "compareTwoStrings: Starting"
    
        let result =
            if str1 > str2 then
                Bigger
            else if str1 < str2 then
                Smaller
            else
                Equal
    
        log (sprintf "compareTwoStrings: result=%A" result)
        log "compareTwoStrings: Finished"
        result

    let writeResult result writeLn =
        match result with
        | Bigger ->
            writeLn "The first value is bigger"
        | Smaller ->
            writeLn "The first value is smaller"
        | Equal ->
            writeLn "The values are equal"
        ()

    let program readStrings compare writeResult =
        let (v1, v2) = readStrings ()
        compare v1 v2 |> writeResult