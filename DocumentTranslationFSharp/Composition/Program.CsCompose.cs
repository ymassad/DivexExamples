using System;
using DIVEX.Core;
using FSharpProject;
using static FSharpProject.FSharpModule;

namespace DocumentTranslationFSharp
{
    [DivexCompose]
    public static partial class Program
    {
        [DIVEX.Core.FunctionsClassAttribute(typeof(global::FSharpProject.FSharpModule))]
        public static partial class SurrogateClassForFSharpModule
        {
        }

        static void Main(string[] args)
        {
            var processDocument = SurrogateClassForFSharpModule.processDocument.Set(translate: SurrogateClassForFSharpModule.translateUsingWebService.Set(webServiceUrl: "http://local.dev/translate").Set(authenticationToken_authTokenForTranslate: 0)).Set(saveDocument: SurrogateClassForFSharpModule.saveDocument).Set(saveTechnicalDocument: SurrogateClassForFSharpModule.saveDocumentToDatabase.Set(tableName_technicalDocumentsTableName: 0)).Set(saveBusinessDocument: SurrogateClassForFSharpModule.saveDocumentToDatabase.Set(tableName: "BusinessDocuments")).Set(saveOtherDocument: SurrogateClassForFSharpModule.saveDocumentToFileSystem.Set(folderPath: "C:\\OtherDocuments"));
            var processDocument1 = processDocument.Set(needsTranslation: SurrogateClassForFSharpModule.detectNeedForTranslationUsing3rdPartyLibrary.Set(modelFile: "c:\\modelFile1.dat"));
            var processDocument2 = processDocument1.Set(classify: SurrogateClassForFSharpModule.classifyUsingWebService.Set(webServiceUrl: "http://local.dev/classify").Set(authenticationToken_authTokenForClassify: 0));
            var processDocument3 = processDocument1.Set(classify: SurrogateClassForFSharpModule.classifyUsing3rdPartyLibrary);
            var processDocument4 = processDocument.Set(needsTranslation: SurrogateClassForFSharpModule.detectNeedForTranslationUsingWebService.Set(webServiceUrl: "http://local.dev/detect").Set(authenticationToken_authTokenForDetect: 0));
            var processDocument5 = processDocument4.Set(classify: SurrogateClassForFSharpModule.classifyUsingWebService.Set(webServiceUrl: "http://local.dev/classify").Set(authenticationToken_authTokenForClassify: 0));
            processDocument2.Invoke(new Document(3, "Hello"), authTokenForTranslate: new AuthenticationToken("Token1"), authTokenForClassify: new AuthenticationToken("Token2"), technicalDocumentsTableName: "TechnicalDocuments3");
            processDocument3.Invoke(new Document(4, "Hi"), authTokenForTranslate: new AuthenticationToken("Token3"), technicalDocumentsTableName: "TechnicalDocuments4");
            processDocument5.Invoke(new Document(5, "Hola"), authTokenForTranslate: new AuthenticationToken("Token1"), authTokenForClassify: new AuthenticationToken("Token2"), authTokenForDetect: new AuthenticationToken("Token3"), technicalDocumentsTableName: "TechnicalDocuments5", detectionLevel: 7);
        }
    }
}
#region DIVEX code

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods1
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass Set(this global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.translateUsingWebServiceToFunctionClass f1, global::System.String webServiceUrl)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(webServiceUrl));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass Apply(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.translateUsingWebServiceToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.translateUsingWebServiceToFunctionClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.translateUsingWebServiceToFunctionClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public global::FSharpProject.FSharpModule.Document Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authenticationToken)
            {
                return this.function.Invoke(document, this.input1, authenticationToken);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods2
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.RenameClass Set(this global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass f1, global::System.Int32 tableName_technicalDocumentsTableName)
        {
            return ContainerForDivexSetArg1.Rename(f1, tableName_technicalDocumentsTableName: 0);
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.RenameClass Rename(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass f1, global::System.Object tableName_technicalDocumentsTableName)
        {
            return new RenameClass(f1);
        }
        [DIVEX.Core.RenameClassAttribute("f1", "technicalDocumentsTableName")]
        public sealed class RenameClass
        {
        
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass f1;
            public RenameClass(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass f1)
            {
                this.f1 = f1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::System.String technicalDocumentsTableName)
            {
                this.f1.Invoke(document, technicalDocumentsTableName);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods3
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass Set(this global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass f1, global::System.String tableName)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(tableName));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass Apply(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document)
            {
                this.function.Invoke(document, this.input1);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods4
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass Set(this global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFileSystemToFunctionClass f1, global::System.String folderPath)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(folderPath));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass Apply(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFileSystemToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFileSystemToFunctionClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFileSystemToFunctionClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document)
            {
                this.function.Invoke(document, this.input1);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods5
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass Set(this global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsing3rdPartyLibraryToFunctionClass f1, global::System.String modelFile)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(modelFile));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass Apply(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsing3rdPartyLibraryToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsing3rdPartyLibraryToFunctionClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsing3rdPartyLibraryToFunctionClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public global::System.Boolean Invoke(global::FSharpProject.FSharpModule.Document document)
            {
                return this.function.Invoke(document, this.input1);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods6
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods6.ContainerForDivexSetArg1.ApplyClass Set(this global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsingWebServiceToFunctionClass f1, global::System.String webServiceUrl)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(webServiceUrl));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods6.ContainerForDivexSetArg1.ApplyClass Apply(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsingWebServiceToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsingWebServiceToFunctionClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsingWebServiceToFunctionClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public global::FSharpProject.FSharpModule.DocumentType Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authenticationToken)
            {
                return this.function.Invoke(document, this.input1, authenticationToken);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods7
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods7.ContainerForDivexSetArg1.ApplyClass Set(this global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsingWebServiceToFunctionClass f1, global::System.String webServiceUrl)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(webServiceUrl));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods7.ContainerForDivexSetArg1.ApplyClass Apply(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsingWebServiceToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsingWebServiceToFunctionClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsingWebServiceToFunctionClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public global::System.Boolean Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authenticationToken, global::System.Int32 detectionLevel)
            {
                return this.function.Invoke(document, this.input1, authenticationToken, detectionLevel);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods8
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods8.ContainerForDivexSetArg1.RenameClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f1, global::System.Int32 authenticationToken_authTokenForTranslate)
        {
            return ContainerForDivexSetArg1.Rename(f1, authenticationToken_authTokenForTranslate: 0);
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods8.ContainerForDivexSetArg1.RenameClass Rename(global::DocumentTranslationFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f1, global::System.Object authenticationToken_authTokenForTranslate)
        {
            return new RenameClass(f1);
        }
        [DIVEX.Core.RenameClassAttribute("f1", "authTokenForTranslate")]
        public sealed class RenameClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f1;
            public RenameClass(global::DocumentTranslationFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f1)
            {
                this.f1 = f1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            public global::FSharpProject.FSharpModule.Document Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate)
            {
                return this.f1.Invoke(document, authTokenForTranslate);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods9
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods6.ContainerForDivexSetArg1.ApplyClass f1, global::System.Int32 authenticationToken_authTokenForClassify)
        {
            return ContainerForDivexSetArg1.Rename(f1, authenticationToken_authTokenForClassify: 0);
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass Rename(global::DocumentTranslationFSharp.SetExtensionMethods6.ContainerForDivexSetArg1.ApplyClass f1, global::System.Object authenticationToken_authTokenForClassify)
        {
            return new RenameClass(f1);
        }
        [DIVEX.Core.RenameClassAttribute("f1", "authTokenForClassify")]
        public sealed class RenameClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods6.ContainerForDivexSetArg1.ApplyClass f1;
            public RenameClass(global::DocumentTranslationFSharp.SetExtensionMethods6.ContainerForDivexSetArg1.ApplyClass f1)
            {
                this.f1 = f1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            public global::FSharpProject.FSharpModule.DocumentType Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForClassify)
            {
                return this.f1.Invoke(document, authTokenForClassify);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods10
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods10.ContainerForDivexSetArg1.RenameClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods7.ContainerForDivexSetArg1.ApplyClass f1, global::System.Int32 authenticationToken_authTokenForDetect)
        {
            return ContainerForDivexSetArg1.Rename(f1, authenticationToken_authTokenForDetect: 0);
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods10.ContainerForDivexSetArg1.RenameClass Rename(global::DocumentTranslationFSharp.SetExtensionMethods7.ContainerForDivexSetArg1.ApplyClass f1, global::System.Object authenticationToken_authTokenForDetect)
        {
            return new RenameClass(f1);
        }
        [DIVEX.Core.RenameClassAttribute("f1", "authTokenForDetect")]
        public sealed class RenameClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods7.ContainerForDivexSetArg1.ApplyClass f1;
            public RenameClass(global::DocumentTranslationFSharp.SetExtensionMethods7.ContainerForDivexSetArg1.ApplyClass f1)
            {
                this.f1 = f1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            public global::System.Boolean Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForDetect, global::System.Int32 detectionLevel)
            {
                return this.f1.Invoke(document, authTokenForDetect, detectionLevel);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods11
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.processDocumentToFunctionClass f1, global::DocumentTranslationFSharp.SetExtensionMethods8.ContainerForDivexSetArg1.RenameClass translate)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods8.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I2>(translate));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.processDocumentToFunctionClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods8.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.processDocumentToFunctionClass f1;
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods8.ContainerForDivexSetArg1.RenameClass f2;
            public InjectClass(global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.processDocumentToFunctionClass f1, global::DocumentTranslationFSharp.SetExtensionMethods8.ContainerForDivexSetArg1.RenameClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::System.Boolean>.Delegate needsTranslation, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::FSharpProject.FSharpModule.Document>.Delegate saveDocument)
            {
                this.f1.Invoke(document, needsTranslation, arg1 => this.f2.Invoke(arg1, authTokenForTranslate), saveDocument);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods12
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFunctionClass saveDocument)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFunctionClass, global::DIVEX.Core.Indexes.Index.I3>(saveDocument));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFunctionClass, global::DIVEX.Core.Indexes.Index.I3> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFunctionClass f2;
            public InjectClass(global::DocumentTranslationFSharp.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2, "global::FSharpProject.FSharpModule.Document")]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::System.Boolean>.Delegate needsTranslation, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::FSharpProject.FSharpModule.DocumentType>.Delegate classify, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::FSharpProject.FSharpModule.Document>.Delegate saveTechnicalDocument, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::FSharpProject.FSharpModule.Document>.Delegate saveBusinessDocument, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::FSharpProject.FSharpModule.Document>.Delegate saveOtherDocument)
            {
                this.f1.Invoke(document, needsTranslation, authTokenForTranslate, arg1 => this.f2.Invoke<global::FSharpProject.FSharpModule.Document>(arg1, classify, saveTechnicalDocument, saveBusinessDocument, saveOtherDocument));
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods13
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.RenameClass saveTechnicalDocument)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I4>(saveTechnicalDocument));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I4> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.RenameClass f2;
            public InjectClass(global::DocumentTranslationFSharp.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.RenameClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(4)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::System.Boolean>.Delegate needsTranslation, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::FSharpProject.FSharpModule.DocumentType>.Delegate classify, global::System.String technicalDocumentsTableName, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::FSharpProject.FSharpModule.Document>.Delegate saveBusinessDocument, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::FSharpProject.FSharpModule.Document>.Delegate saveOtherDocument)
            {
                this.f1.Invoke(document, needsTranslation, authTokenForTranslate, classify, arg1 => this.f2.Invoke(arg1, technicalDocumentsTableName), saveBusinessDocument, saveOtherDocument);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods14
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass saveBusinessDocument)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I5>(saveBusinessDocument));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I5> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::DocumentTranslationFSharp.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(5)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::System.Boolean>.Delegate needsTranslation, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::FSharpProject.FSharpModule.DocumentType>.Delegate classify, global::System.String technicalDocumentsTableName, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::FSharpProject.FSharpModule.Document>.Delegate saveOtherDocument)
            {
                this.f1.Invoke(document, needsTranslation, authTokenForTranslate, classify, technicalDocumentsTableName, arg1 => this.f2.Invoke(arg1), saveOtherDocument);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods15
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass saveOtherDocument)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I5>(saveOtherDocument));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I5> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::DocumentTranslationFSharp.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(5)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::System.Boolean>.Delegate needsTranslation, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::FSharpProject.FSharpModule.DocumentType>.Delegate classify, global::System.String technicalDocumentsTableName)
            {
                this.f1.Invoke(document, needsTranslation, authTokenForTranslate, classify, technicalDocumentsTableName, arg1 => this.f2.Invoke(arg1));
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods16
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass needsTranslation)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I1>(needsTranslation));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::FSharpProject.FSharpModule.DocumentType>.Delegate classify, global::System.String technicalDocumentsTableName)
            {
                this.f1.Invoke(document, arg1 => this.f2.Invoke(arg1), authTokenForTranslate, classify, technicalDocumentsTableName);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods17
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods17.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass classify)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I2>(classify));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods17.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass f2;
            public InjectClass(global::DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForClassify, global::System.String technicalDocumentsTableName)
            {
                this.f1.Invoke(document, authTokenForTranslate, arg1 => this.f2.Invoke(arg1, authTokenForClassify), technicalDocumentsTableName);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods18
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods18.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsing3rdPartyLibraryToFunctionClass classify)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsing3rdPartyLibraryToFunctionClass, global::DIVEX.Core.Indexes.Index.I2>(classify));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods18.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsing3rdPartyLibraryToFunctionClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsing3rdPartyLibraryToFunctionClass f2;
            public InjectClass(global::DocumentTranslationFSharp.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsing3rdPartyLibraryToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::System.String technicalDocumentsTableName)
            {
                this.f1.Invoke(document, authTokenForTranslate, arg1 => this.f2.Invoke(arg1), technicalDocumentsTableName);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods19
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods10.ContainerForDivexSetArg1.RenameClass needsTranslation)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods10.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I1>(needsTranslation));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods10.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods10.ContainerForDivexSetArg1.RenameClass f2;
            public InjectClass(global::DocumentTranslationFSharp.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods10.ContainerForDivexSetArg1.RenameClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForDetect, global::System.Int32 detectionLevel, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::FSharpProject.FSharpModule.DocumentType>.Delegate classify, global::System.String technicalDocumentsTableName)
            {
                this.f1.Invoke(document, arg1 => this.f2.Invoke(arg1, authTokenForDetect, detectionLevel), authTokenForTranslate, classify, technicalDocumentsTableName);
            }
        
        }
    
    }
    
    }
}

namespace DocumentTranslationFSharp
{
    
    public static class SetExtensionMethods20
    {
    
        public static global::DocumentTranslationFSharp.SetExtensionMethods20.ContainerForDivexSetArg1.InjectClass Set(this global::DocumentTranslationFSharp.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass classify)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I4>(classify));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DocumentTranslationFSharp.SetExtensionMethods20.ContainerForDivexSetArg1.InjectClass Inject(global::DocumentTranslationFSharp.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I4> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass f2;
            public InjectClass(global::DocumentTranslationFSharp.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass f1, global::DocumentTranslationFSharp.SetExtensionMethods9.ContainerForDivexSetArg1.RenameClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(4)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::FSharpProject.FSharpModule.Document document, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForDetect, global::System.Int32 detectionLevel, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForTranslate, global::FSharpProject.FSharpModule.AuthenticationToken authTokenForClassify, global::System.String technicalDocumentsTableName)
            {
                this.f1.Invoke(document, authTokenForDetect, detectionLevel, authTokenForTranslate, arg1 => this.f2.Invoke(arg1, authTokenForClassify), technicalDocumentsTableName);
            }
        
        }
    
    }
    
    }
}





namespace DocumentTranslationFSharp
{
    public static partial class Program
{
    [DIVEX.Core.OriginalClassTypeAttribute(typeof(global::FSharpProject.FSharpModule))]
public static partial class SurrogateClassForFSharpModule
{
    public static DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.processDocumentToFunctionClass processDocument
    {
        get
        {
            return new DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.processDocumentToFunctionClass();
        }
    }
    public static DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsing3rdPartyLibraryToFunctionClass detectNeedForTranslationUsing3rdPartyLibrary
    {
        get
        {
            return new DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsing3rdPartyLibraryToFunctionClass();
        }
    }
    public static DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsingWebServiceToFunctionClass detectNeedForTranslationUsingWebService
    {
        get
        {
            return new DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.detectNeedForTranslationUsingWebServiceToFunctionClass();
        }
    }
    public static DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.translateUsingWebServiceToFunctionClass translateUsingWebService
    {
        get
        {
            return new DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.translateUsingWebServiceToFunctionClass();
        }
    }
    public static DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsing3rdPartyLibraryToFunctionClass classifyUsing3rdPartyLibrary
    {
        get
        {
            return new DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsing3rdPartyLibraryToFunctionClass();
        }
    }
    public static DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsingWebServiceToFunctionClass classifyUsingWebService
    {
        get
        {
            return new DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.classifyUsingWebServiceToFunctionClass();
        }
    }
    public static DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFunctionClass saveDocument
    {
        get
        {
            return new DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFunctionClass();
        }
    }
    public static DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass saveDocumentToDatabase
    {
        get
        {
            return new DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToDatabaseToFunctionClass();
        }
    }
    public static DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFileSystemToFunctionClass saveDocumentToFileSystem
    {
        get
        {
            return new DocumentTranslationFSharp.Program.SurrogateClassForFSharpModule.saveDocumentToFileSystemToFunctionClass();
        }
    }

    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "processDocument")]
    public sealed class processDocumentToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("processDocument", 0, "FSharpProject.FSharpModule.Document", "Microsoft.FSharp.Core.FSharpFunc<FSharpProject.FSharpModule.Document, System.Boolean>", "Microsoft.FSharp.Core.FSharpFunc<FSharpProject.FSharpModule.Document, FSharpProject.FSharpModule.Document>", "Microsoft.FSharp.Core.FSharpFunc<FSharpProject.FSharpModule.Document, Microsoft.FSharp.Core.Unit>")]
        public void Invoke(global::FSharpProject.FSharpModule.Document document, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::System.Boolean>.Delegate needsTranslation, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::FSharpProject.FSharpModule.Document>.Delegate translate, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::FSharpProject.FSharpModule.Document>.Delegate saveDocument)
        {
            global::FSharpProject.FSharpModule.processDocument(document, (needsTranslation is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::System.Boolean>(needsTranslation), (translate is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.Document, global::FSharpProject.FSharpModule.Document>(translate), (saveDocument is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::FSharpProject.FSharpModule.Document>(saveDocument));
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "detectNeedForTranslationUsing3rdPartyLibrary")]
    public sealed class detectNeedForTranslationUsing3rdPartyLibraryToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("detectNeedForTranslationUsing3rdPartyLibrary", 0, "FSharpProject.FSharpModule.Document", "System.String")]
        public global::System.Boolean Invoke(global::FSharpProject.FSharpModule.Document document, global::System.String modelFile)
        {
            return global::FSharpProject.FSharpModule.detectNeedForTranslationUsing3rdPartyLibrary(document, modelFile);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "detectNeedForTranslationUsingWebService")]
    public sealed class detectNeedForTranslationUsingWebServiceToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("detectNeedForTranslationUsingWebService", 0, "FSharpProject.FSharpModule.Document", "System.String", "FSharpProject.FSharpModule.AuthenticationToken", "System.Int32")]
        public global::System.Boolean Invoke(global::FSharpProject.FSharpModule.Document document, global::System.String webServiceUrl, global::FSharpProject.FSharpModule.AuthenticationToken authenticationToken, global::System.Int32 detectionLevel)
        {
            return global::FSharpProject.FSharpModule.detectNeedForTranslationUsingWebService(document, webServiceUrl, authenticationToken, detectionLevel);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "translateUsingWebService")]
    public sealed class translateUsingWebServiceToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("translateUsingWebService", 0, "FSharpProject.FSharpModule.Document", "System.String", "FSharpProject.FSharpModule.AuthenticationToken")]
        public global::FSharpProject.FSharpModule.Document Invoke(global::FSharpProject.FSharpModule.Document document, global::System.String webServiceUrl, global::FSharpProject.FSharpModule.AuthenticationToken authenticationToken)
        {
            return global::FSharpProject.FSharpModule.translateUsingWebService(document, webServiceUrl, authenticationToken);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "classifyUsing3rdPartyLibrary")]
    public sealed class classifyUsing3rdPartyLibraryToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("classifyUsing3rdPartyLibrary", 0, "FSharpProject.FSharpModule.Document")]
        public global::FSharpProject.FSharpModule.DocumentType Invoke(global::FSharpProject.FSharpModule.Document document)
        {
            return global::FSharpProject.FSharpModule.classifyUsing3rdPartyLibrary(document);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "classifyUsingWebService")]
    public sealed class classifyUsingWebServiceToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("classifyUsingWebService", 0, "FSharpProject.FSharpModule.Document", "System.String", "FSharpProject.FSharpModule.AuthenticationToken")]
        public global::FSharpProject.FSharpModule.DocumentType Invoke(global::FSharpProject.FSharpModule.Document document, global::System.String webServiceUrl, global::FSharpProject.FSharpModule.AuthenticationToken authenticationToken)
        {
            return global::FSharpProject.FSharpModule.classifyUsingWebService(document, webServiceUrl, authenticationToken);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "saveDocument")]
    public sealed class saveDocumentToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("saveDocument", 1, "a", "Microsoft.FSharp.Core.FSharpFunc<a, FSharpProject.FSharpModule.DocumentType>", "Microsoft.FSharp.Core.FSharpFunc<a, Microsoft.FSharp.Core.Unit>", "Microsoft.FSharp.Core.FSharpFunc<a, Microsoft.FSharp.Core.Unit>", "Microsoft.FSharp.Core.FSharpFunc<a, Microsoft.FSharp.Core.Unit>")]
        public void Invoke<a>(a document, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<a, global::FSharpProject.FSharpModule.DocumentType>.Delegate classify, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<a>.Delegate saveTechnicalDocument, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<a>.Delegate saveBusinessDocument, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<a>.Delegate saveOtherDocument)
        {
            global::FSharpProject.FSharpModule.saveDocument<a>(document, (classify is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<a, global::FSharpProject.FSharpModule.DocumentType>(classify), (saveTechnicalDocument is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<a>(saveTechnicalDocument), (saveBusinessDocument is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<a>(saveBusinessDocument), (saveOtherDocument is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<a>(saveOtherDocument));
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "saveDocumentToDatabase")]
    public sealed class saveDocumentToDatabaseToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("saveDocumentToDatabase", 0, "FSharpProject.FSharpModule.Document", "System.String")]
        public void Invoke(global::FSharpProject.FSharpModule.Document document, global::System.String tableName)
        {
            global::FSharpProject.FSharpModule.saveDocumentToDatabase(document, tableName);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "saveDocumentToFileSystem")]
    public sealed class saveDocumentToFileSystemToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("saveDocumentToFileSystem", 0, "FSharpProject.FSharpModule.Document", "System.String")]
        public void Invoke(global::FSharpProject.FSharpModule.Document document, global::System.String folderPath)
        {
            global::FSharpProject.FSharpModule.saveDocumentToFileSystem(document, folderPath);
        }
    
    }

}
}
}

#endregion
