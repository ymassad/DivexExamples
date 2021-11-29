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

    let recordFileSize httpPost serverUrl filename (size: int64) =
        let message = sprintf "{filename: %s, size: %i }" filename size
        httpPost serverUrl message

    let uploadFile serverUrl useHttpPut filename = 
        printf "Uploading file %s to %s. Using HTTP put %b" filename serverUrl useHttpPut

    let getFiles folderPath (searchOption: SearchOption) =
        Directory.GetFiles (folderPath, "*.*", searchOption)
    
    let getFileSize filename =
        FileInfo(filename).Length

    let httpPost log serverUrl message =
        sprintf "Posting %s to %s" message serverUrl |> log
        printf "Posting %s to %s" message serverUrl

    let log1 = logToFile "c:\\log1.txt"
    let httpPost1 = httpPost log1
    let uploadFile1 = uploadFile "https://server2.demo" false
    let recordFileSize1 = recordFileSize httpPost1 "https://server1.demo"
    let processFile1 = processFile getFileSize recordFileSize1 uploadFile1 log1
    let processFolder1 = processFolder processFile1 log1 true getFiles

