namespace FSharpProject

open System.IO
open System

module FSharpModule1 =
    let processFolder processFile log processSubFolders getFiles folderPath =
        let searchOption = if processSubFolders then SearchOption.AllDirectories else SearchOption.TopDirectoryOnly
        let files = getFiles folderPath searchOption
        files |> Array.iter 
            (fun file -> (sprintf "Processing file %s" file |> log; processFile file; ))

    let logToFile filename message =
        File.AppendAllText (filename, sprintf "%s\r\n" message)

    let processFile getFileSize recordFileSize uploadFile log filename =
        sprintf "Uploading file %s" filename |> log
        uploadFile filename
        let size = getFileSize filename
        sprintf "Recording filesize %s" filename |> log
        recordFileSize filename size

    let recordFileSize httpPost (serverUrl: Uri ) filename (size: int64) =
        let message = sprintf "{operation: 'recordSize', filename: %s, size: %i }" filename size
        httpPost serverUrl message

    let uploadFile (serverUrl: Uri) useHttpPut httpPost httpPut readFile filename = 
        let fileContents = readFile filename
        let fileContentsBase64 = Convert.ToBase64String(fileContents)
        let message = sprintf "{operation: 'upload', filename: %s, contents: %s }" filename fileContentsBase64
        let httpFunction = if useHttpPut then httpPut else httpPost
        httpFunction serverUrl message

    let getFiles folderPath (searchOption: SearchOption) =
        Directory.GetFiles (folderPath, "*.*", searchOption)
    
    let getFileSize filename =
        FileInfo(filename).Length

    let httpPost log (serverUrl: Uri) message =
        sprintf "Posting %s to %O" message serverUrl |> log
        printf "Posting %s to %O" message serverUrl

    let httpPut log (serverUrl: Uri) message =
        sprintf "Putting %s to %O" message serverUrl |> log
        printf "Putting %s to %O" message serverUrl

    let server1Url = Uri("https://server1.demo");
    let server2Url = Uri("https://server2.demo");
    let log1 = logToFile "c:\\log1.txt"
    let httpPost1 = httpPost log1
    let httpPut1 = httpPut log1
    let uploadFile1 = uploadFile server2Url false httpPost1 httpPut1 File.ReadAllBytes
    let recordFileSize1 = recordFileSize httpPost1 server1Url
    let processFile1 = processFile getFileSize recordFileSize1 uploadFile1 log1
    let processFolder1 = processFolder processFile1 log1 true getFiles
