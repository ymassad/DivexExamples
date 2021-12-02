namespace FSharpProject

open System.IO
open System

module FSharpModule2 =
    let processFolder folderPath processFile log processSubFolders getFiles =
        let searchOption =
            if processSubFolders then
                SearchOption.AllDirectories
            else
                SearchOption.TopDirectoryOnly
        let files = getFiles folderPath searchOption
        files |> Array.iter 
            (fun file -> (sprintf "Processing file %s" file |> log; processFile file; ))

    let logToFile message filename =
        File.AppendAllText (filename, sprintf "%s\r\n" message)

    let processFile filename getFileSize recordFileSize uploadFile log =
        sprintf "Uploading file %s" filename |> log
        uploadFile filename
        let size = getFileSize filename
        sprintf "Recording filesize %s" filename |> log
        recordFileSize filename size

    let recordFileSize filename (size: int64) httpPost (serverUrl: Uri ) =
        let message =
            sprintf "{operation: 'recordSize', filename: %s, size: %i }" filename size
        httpPost serverUrl message

    let uploadFile filename (serverUrl: Uri) useHttpPut httpPost httpPut readFile = 
        let fileContents = readFile filename
        let fileContentsBase64 = Convert.ToBase64String(fileContents)
        let message =
            sprintf
                "{operation: 'upload', filename: %s, contents: %s }"
                filename
                fileContentsBase64
        let httpFunction = if useHttpPut then httpPut else httpPost
        httpFunction serverUrl message

    let getFiles folderPath (searchOption: SearchOption) =
        Directory.GetFiles (folderPath, "*.*", searchOption)
    
    let getFileSize filename =
        FileInfo(filename).Length

    let httpPost (serverUrl: Uri) message log =
        sprintf "Posting %s to %O" message serverUrl |> log
        printf "Posting %s to %O" message serverUrl

    let httpPut (serverUrl: Uri) message log =
        sprintf "Putting %s to %O" message serverUrl |> log
        printf "Putting %s to %O" message serverUrl
