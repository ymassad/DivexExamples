namespace FSharpProject

module FSharpModule =
    type Document = { Id: int; Contents: string;}
    type AuthenticationToken = { Value: string;}

    type DocumentType =
       | Technical
       | Financial
       | Administrative
       | Other

    let processDocument document needsTranslation translate saveDocument =
        printfn "Processing document %i" document.Id
        if needsTranslation document  then
            document |> translate |> saveDocument
        else
            document |> saveDocument
        ()

    let detectNeedForTranslationUsing3rdPartyLibrary document modelFile =
        printfn "Detecting need for translation of document %i using 3rd party library. Model file: %s" document.Id modelFile
        true

    let detectNeedForTranslationUsingWebService document webServiceUrl (authenticationToken : AuthenticationToken) detectionLevel =
        printfn "Detecting need for translation of document %i using web service %s. Detection level: %i" document.Id webServiceUrl detectionLevel
        true

    let translateUsing3rdPartyLibrary document modelFile =
        printfn "Translating document %i using 3rd party library. Model file: %s" document.Id modelFile
        document

    let translateUsingWebService document webServiceUrl (authenticationToken : AuthenticationToken) =
        printfn "Translating document %i using web service %s" document.Id webServiceUrl
        document

    let classifyUsing3rdPartyLibrary document =
        printfn "Classifying document %i using 3rd party library" document.Id
        Financial

    let classifyUsingWebService document webServiceUrl (authenticationToken : AuthenticationToken) =
        printfn "Classifying document %i using web service %s" document.Id webServiceUrl
        Technical

    let saveDocument document classify saveTechnicalDocument saveBusinessDocument saveOtherDocument =
        match document |> classify with
            | Technical -> saveTechnicalDocument document
            | Financial | Administrative -> saveBusinessDocument document
            | _ -> saveOtherDocument document     
        ()

    let saveDocumentToDatabase document tableName =
        printfn "Saving document %i to database table %s" document.Id tableName
        ()

    let saveDocumentToFileSystem document folderPath =
        printfn "Saving document %i to folder %s" document.Id folderPath
        ()