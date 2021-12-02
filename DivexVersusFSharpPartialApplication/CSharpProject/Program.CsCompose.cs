using System;
using DIVEX.Core;
using static FSharpProject.FSharpModule2;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FluentAssertions;

namespace CSharpProject
{
    [DivexCompose]
    public static partial class Program
    {
        [DIVEX.Core.FunctionsClassAttribute(typeof(global::FSharpProject.FSharpModule2))]
        public static partial class SurrogateClassForFSharpModule2
        {
        }

        [DIVEX.Core.FunctionsClassAttribute(typeof(global::System.IO.File))]
        public static partial class SurrogateClassForFile
        {
        }

        static void Main(string[] args)
        {
            /*
    let log1 = logToFile "c:\\log1.txt"
    let httpPost1 = httpPost log1
    let uploadFile1 = uploadFile "https://server2.demo" false
    let recordFileSize1 = recordFileSize httpPost1 "https://server1.demo"
    let processFile1 = processFile getFileSize recordFileSize1 uploadFile1 log1
    let processFolder1 = processFolder processFile1 log1 true getFiles
*/
            Test();
            return;
            var processFolderPotentiallyPure = Create();
            var log = SurrogateClassForFSharpModule2.logToFile.Set(filename: "c:\\log1.txt");
            var httpPost1 = SurrogateClassForFSharpModule2.httpPost.Set(log: log);
            var httpPut1 = SurrogateClassForFSharpModule2.httpPut.Set(log: log);
            var processFolderImpure = processFolderPotentiallyPure.Set(log: log).Set(getFileSize: SurrogateClassForFSharpModule2.getFileSize).Set(httpPost: httpPost1).Set(httpPut: httpPut1).Set(getFiles: SurrogateClassForFSharpModule2.getFiles).Set(readFile: SurrogateClassForFile.ReadAllBytes);
            processFolderImpure.Invoke("c:\\folder1");
        }

        public static void Test()
        {
            var logList = new List<string>();
            var httpPostList = new List<(Uri serverUri, string message)>();
            var httpPutList = new List<(Uri serverUri, string message)>();
            var files = new Dictionary<string, byte[]>{["c:\\folder1\\file1.txt"] = new byte[]{0x1, 0x2, 0x3, 0x4}, ["c:\\folder1\\file2.txt"] = new byte[]{0x1, 0x2, 0x3, 0x4, 0x5, 0x6}, };
            void Log(string message) => logList.Add(message);
            string[] GetFiles(string folder, SearchOption searchOptions)
            {
                if (folder != "c:\\folder1")
                    return Array.Empty<string>();
                return files.Keys.ToArray();
            }

            long GetFileSize(string filename) => files[filename].Length;
            void HttpPost(Uri serverUri, string message) => httpPostList.Add((serverUri, message));
            void HttpPut(Uri serverUri, string message) => httpPutList.Add((serverUri, message));
            byte[] ReadFile(string filename) => files[filename];
            var processFolderPotentiallyPure = Create();
            var process = processFolderPotentiallyPure.Set(log: ((DelFunc.DF1)Log)).Set(getFiles: ((DelFunc.DF2)GetFiles)).Set(getFileSize: ((DelFunc.DF3)GetFileSize)).Set(httpPost: ((DelFunc.DF4)HttpPost)).Set(httpPut: ((DelFunc.DF5)HttpPut)).Set(readFile: ((DelFunc.DF6)ReadFile));
            process.Invoke("c:\\folder1");
            logList.Should().BeEquivalentTo(new[]{"Processing file c:\\folder1\\file1.txt", "Uploading file c:\\folder1\\file1.txt", "Recording filesize c:\\folder1\\file1.txt", "Processing file c:\\folder1\\file2.txt", "Uploading file c:\\folder1\\file2.txt", "Recording filesize c:\\folder1\\file2.txt"});
            httpPostList.Should().BeEquivalentTo(new[]{(new Uri("https://server2.demo"), "{operation: 'upload', filename: c:\\folder1\\file1.txt, contents: AQIDBA== }"), (new Uri("https://server1.demo"), "{operation: 'recordSize', filename: c:\\folder1\\file1.txt, size: 4 }"), (new Uri("https://server2.demo"), "{operation: 'upload', filename: c:\\folder1\\file2.txt, contents: AQIDBAUG }"), (new Uri("https://server1.demo"), "{operation: 'recordSize', filename: c:\\folder1\\file2.txt, size: 6 }")});
            httpPutList.Should().BeEmpty();
        }

        public static VarReturn.VR1 Create()
        {
            var processFolderPotentiallyPure = SurrogateClassForFSharpModule2.processFolder.Set(processSubFolders: true).Set(processFile: SurrogateClassForFSharpModule2.processFile).Set(recordFileSize: SurrogateClassForFSharpModule2.recordFileSize.Set(serverUrl: new Uri("https://server1.demo"))).Set(uploadFile: SurrogateClassForFSharpModule2.uploadFile.Set(serverUrl: new Uri("https://server2.demo"), useHttpPut: false)).JoinByName(log: 0).JoinByName(httpPost: 0);
            return processFolderPotentiallyPure;
        }
    }
}
#region DIVEX code

namespace CSharpProject
{
    
    public static class JoinByNameExtensionMethods1
    {
    
        public static CSharpProject.JoinByNameExtensionMethods1.JoinByNameClass JoinByName(this global::CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass function, global::System.Object log)
        {
            return new JoinByNameClass(function);
        }
        [DIVEX.Core.JoinByNameClassAttribute("function", "log")]
        public sealed class JoinByNameClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass function;
            public JoinByNameClass(global::CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass function)
            {
                this.function = function;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.JoinedParametersDetailsAttribute("0,1,2,3,4,5,(6;7),8")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, [DIVEX.Core.ParameterNameAttribute("httpPost")]global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost1, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.function.Invoke<a>(folderPath,new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate(getFileSize),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate(httpPost),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate(httpPost1),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate(httpPut),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate(readFile),new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate(log),new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate(log),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate(getFiles));
            }
        
        }
    
    }
}

namespace CSharpProject
{
    
    public static class JoinByNameExtensionMethods2
    {
    
        public static CSharpProject.JoinByNameExtensionMethods2.JoinByNameClass JoinByName(this global::CSharpProject.JoinByNameExtensionMethods1.JoinByNameClass function, global::System.Object httpPost)
        {
            return new JoinByNameClass(function);
        }
        [DIVEX.Core.JoinByNameClassAttribute("function", "httpPost")]
        public sealed class JoinByNameClass
        {
        
            public readonly global::CSharpProject.JoinByNameExtensionMethods1.JoinByNameClass function;
            public JoinByNameClass(global::CSharpProject.JoinByNameExtensionMethods1.JoinByNameClass function)
            {
                this.function = function;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.JoinedParametersDetailsAttribute("0,1,(2;3),4,5,6,7")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.function.Invoke<a>(folderPath,new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate(getFileSize),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate(httpPost),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate(httpPost),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate(httpPut),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate(readFile),new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate(log),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate(getFiles));
            }
        
        }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods1
    {
    
        public static global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.logToFileToFunctionClass f1, global::System.String filename)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(filename));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass Apply(global::CSharpProject.Program.SurrogateClassForFSharpModule2.logToFileToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.logToFileToFunctionClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::CSharpProject.Program.SurrogateClassForFSharpModule2.logToFileToFunctionClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public void Invoke(global::System.String message)
            {
                this.function.Invoke(message, this.input1);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods2
    {
    
        public static global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFolderToFunctionClass f1, global::System.Boolean processSubFolders)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.Boolean, global::DIVEX.Core.Indexes.Index.I3>(processSubFolders));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass Apply(global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFolderToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.Boolean, global::DIVEX.Core.Indexes.Index.I3> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFolderToFunctionClass function;
            public readonly global::System.Boolean input1;
            public ApplyClass(global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFolderToFunctionClass function, global::System.Boolean input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate processFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.function.Invoke<a>(folderPath, processFile, log, this.input1, getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods3
    {
    
        public static global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass f1, global::System.Uri serverUrl)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.Uri, global::DIVEX.Core.Indexes.Index.I3>(serverUrl));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass Apply(global::CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.Uri, global::DIVEX.Core.Indexes.Index.I3> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass function;
            public readonly global::System.Uri input1;
            public ApplyClass(global::CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass function, global::System.Uri input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            public a Invoke<a>(global::System.String filename, global::System.Int64 size, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>.Delegate httpPost)
            {
                return this.function.Invoke<a>(filename, size, httpPost, this.input1);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods4
    {
    
        public static global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg2.ApplyClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass f1, global::System.Uri serverUrl, global::System.Boolean useHttpPut)
        {
            return ContainerForDivexSetArg2.Apply(ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.Uri, global::DIVEX.Core.Indexes.Index.I1>(serverUrl)), new global::DIVEX.Core.ValueByIndex<global::System.Boolean, global::DIVEX.Core.Indexes.Index.I1>(useHttpPut));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass Apply(global::CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.Uri, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass function;
            public readonly global::System.Uri input1;
            public ApplyClass(global::CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass function, global::System.Uri input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            public a Invoke<a>(global::System.String filename, global::System.Boolean useHttpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile)
            {
                return this.function.Invoke<a>(filename, this.input1, useHttpPut, httpPost, httpPut, readFile);
            }
        
        }
    
    }
    
    
    public static class ContainerForDivexSetArg2
    {
    
        public static CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg2.ApplyClass Apply(global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass function, global::DIVEX.Core.ValueByIndex<global::System.Boolean, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass function;
            public readonly global::System.Boolean input1;
            public ApplyClass(global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass function, global::System.Boolean input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            public a Invoke<a>(global::System.String filename, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile)
            {
                return this.function.Invoke<a>(filename, this.input1, httpPost, httpPut, readFile);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods5
    {
    
        public static global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass processFile)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass, global::DIVEX.Core.Indexes.Index.I1>(processFile));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass f1;
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2, "$1$", "global::DIVEX.Core.Unit")]
            public void Invoke<a, [DIVEX.Core.ParameterNameAttribute("a")]a1>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, a1>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, a1, global::DIVEX.Core.Unit>.Delegate recordFileSize, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate uploadFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, [DIVEX.Core.ParameterNameAttribute("log")]global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log1, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, arg1 => this.f2.Invoke<a1, global::DIVEX.Core.Unit>(arg1, getFileSize, recordFileSize, uploadFile, log), log1, getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods6
    {
    
        public static global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass f1, global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass log)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2>(log));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass f1;
            public readonly global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass f1, global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f2)
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
            public void Invoke(global::System.Uri serverUrl, global::System.String message)
            {
                this.f1.Invoke(serverUrl, message, arg1 => this.f2.Invoke(arg1));
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods7
    {
    
        public static global::CSharpProject.SetExtensionMethods7.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPutToFunctionClass f1, global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass log)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2>(log));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods7.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPutToFunctionClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPutToFunctionClass f1;
            public readonly global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPutToFunctionClass f1, global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f2)
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
            public void Invoke(global::System.Uri serverUrl, global::System.String message)
            {
                this.f1.Invoke(serverUrl, message, arg1 => this.f2.Invoke(arg1));
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods8
    {
    
        public static global::CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass recordFileSize)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2>(recordFileSize));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0,1)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$", "global::System.Int64")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2, "global::DIVEX.Core.Unit")]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate uploadFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, [DIVEX.Core.ParameterNameAttribute("log")]global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log1, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a, global::System.Int64>(folderPath, getFileSize, (arg1, arg2) => this.f2.Invoke<global::DIVEX.Core.Unit>(arg1, arg2, httpPost), uploadFile, log, log1, getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods9
    {
    
        public static global::CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg2.ApplyClass uploadFile)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg2.ApplyClass, global::DIVEX.Core.Indexes.Index.I3>(uploadFile));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg2.ApplyClass, global::DIVEX.Core.Indexes.Index.I3> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg2.ApplyClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg2.ApplyClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2, "global::DIVEX.Core.Unit")]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, [DIVEX.Core.ParameterNameAttribute("httpPost")]global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost1, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, [DIVEX.Core.ParameterNameAttribute("log")]global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log1, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, getFileSize, httpPost, arg1 => this.f2.Invoke<global::DIVEX.Core.Unit>(arg1, httpPost1, httpPut, readFile), log, log1, getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods10
    {
    
        public static global::CSharpProject.SetExtensionMethods10.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.Program.VarReturn.VR1 f1, global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass log)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I5>(log));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods10.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.Program.VarReturn.VR1 f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I5> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.Program.VarReturn.VR1 f1;
            public readonly global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::CSharpProject.Program.VarReturn.VR1 f1, global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(5)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, getFileSize, httpPost, httpPut, readFile, arg1 => this.f2.Invoke(arg1), getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods11
    {
    
        public static global::CSharpProject.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.Program.VarReturn.VR1 f1, global::CSharpProject.Program.DelFunc.DF1 log)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF1, global::DIVEX.Core.Indexes.Index.I5>(log));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.Program.VarReturn.VR1 f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF1, global::DIVEX.Core.Indexes.Index.I5> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.Program.VarReturn.VR1 f1;
            public readonly global::CSharpProject.Program.DelFunc.Adapters.DF1 f2;
            public InjectClass(global::CSharpProject.Program.VarReturn.VR1 f1, global::CSharpProject.Program.DelFunc.Adapters.DF1 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(5)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, getFileSize, httpPost, httpPut, readFile, arg1 => this.f2.Invoke(arg1), getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods12
    {
    
        public static global::CSharpProject.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods10.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass getFileSize)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass, global::DIVEX.Core.Indexes.Index.I1>(getFileSize));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods10.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods10.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods10.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, arg1 => this.f2.Invoke(arg1), httpPost, httpPut, readFile, getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods13
    {
    
        public static global::CSharpProject.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.DF2 getFiles)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF2, global::DIVEX.Core.Indexes.Index.I5>(getFiles));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF2, global::DIVEX.Core.Indexes.Index.I5> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.Program.DelFunc.Adapters.DF2 f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods11.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.Adapters.DF2 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0,1)]
            [DIVEX.Core.ParameterIndexAttribute(5)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "global::System.String")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile)
            {
                this.f1.Invoke<global::System.String>(folderPath, getFileSize, httpPost, httpPut, readFile, (arg1, arg2) => this.f2.Invoke(arg1, arg2));
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods14
    {
    
        public static global::CSharpProject.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass httpPost)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass, global::DIVEX.Core.Indexes.Index.I1>(httpPost));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods12.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0,1)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, (arg1, arg2) =>
                {
                    this.f2.Invoke(arg1, arg2);
                    return null;
                }, httpPut, readFile, getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods15
    {
    
        public static global::CSharpProject.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.DF3 getFileSize)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF3, global::DIVEX.Core.Indexes.Index.I1>(getFileSize));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF3, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.Program.DelFunc.Adapters.DF3 f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods13.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.Adapters.DF3 f2)
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
            public void Invoke(global::System.String folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile)
            {
                this.f1.Invoke(folderPath, arg1 => this.f2.Invoke(arg1), httpPost, httpPut, readFile);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods16
    {
    
        public static global::CSharpProject.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods7.ContainerForDivexSetArg1.InjectClass httpPut)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods7.ContainerForDivexSetArg1.InjectClass, global::DIVEX.Core.Indexes.Index.I1>(httpPut));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods7.ContainerForDivexSetArg1.InjectClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.SetExtensionMethods7.ContainerForDivexSetArg1.InjectClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods14.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods7.ContainerForDivexSetArg1.InjectClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0,1)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, (arg1, arg2) =>
                {
                    this.f2.Invoke(arg1, arg2);
                    return null;
                }, readFile, getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods17
    {
    
        public static global::CSharpProject.SetExtensionMethods17.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.DF4 httpPost)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF4, global::DIVEX.Core.Indexes.Index.I1>(httpPost));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods17.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF4, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.Program.DelFunc.Adapters.DF4 f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods15.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.Adapters.DF4 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0,1)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile)
            {
                this.f1.Invoke(folderPath, (arg1, arg2) =>
                {
                    this.f2.Invoke(arg1, arg2);
                    return null;
                }, httpPut, readFile);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods18
    {
    
        public static global::CSharpProject.SetExtensionMethods18.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFilesToFunctionClass getFiles)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFilesToFunctionClass, global::DIVEX.Core.Indexes.Index.I2>(getFiles));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods18.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFilesToFunctionClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFilesToFunctionClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods16.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFilesToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0,1)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "global::System.String")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile)
            {
                this.f1.Invoke<global::System.String>(folderPath, readFile, (arg1, arg2) => this.f2.Invoke(arg1, arg2));
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods19
    {
    
        public static global::CSharpProject.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods17.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.DF5 httpPut)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF5, global::DIVEX.Core.Indexes.Index.I1>(httpPut));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods17.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF5, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods17.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.Program.DelFunc.Adapters.DF5 f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods17.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.Adapters.DF5 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0,1)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile)
            {
                this.f1.Invoke(folderPath, (arg1, arg2) =>
                {
                    this.f2.Invoke(arg1, arg2);
                    return null;
                }, readFile);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods20
    {
    
        public static global::CSharpProject.SetExtensionMethods20.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods18.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.SurrogateClassForFile.ReadAllBytesToFunctionClass readFile)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFile.ReadAllBytesToFunctionClass, global::DIVEX.Core.Indexes.Index.I1>(readFile));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods20.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods18.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFile.ReadAllBytesToFunctionClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods18.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.Program.SurrogateClassForFile.ReadAllBytesToFunctionClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods18.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.SurrogateClassForFile.ReadAllBytesToFunctionClass f2)
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
            public void Invoke(global::System.String folderPath)
            {
                this.f1.Invoke(folderPath, arg1 => this.f2.Invoke(arg1));
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods21
    {
    
        public static global::CSharpProject.SetExtensionMethods21.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.DF6 readFile)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF6, global::DIVEX.Core.Indexes.Index.I1>(readFile));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods21.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.DelFunc.DF6, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.Program.DelFunc.Adapters.DF6 f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods19.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.DelFunc.Adapters.DF6 f2)
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
            public void Invoke(global::System.String folderPath)
            {
                this.f1.Invoke(folderPath, arg1 => this.f2.Invoke(arg1));
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    public static partial class Program
    {
        public sealed partial class VarReturn
        {
        
            [DIVEX.Core.VarReturnClassAttribute()]
            public sealed class VR1
            {
            
                public static implicit operator CSharpProject.Program.VarReturn.VR1(global::CSharpProject.JoinByNameExtensionMethods2.JoinByNameClass cfc)
                {
                    return new CSharpProject.Program.VarReturn.VR1(cfc);
                }
                public readonly global::CSharpProject.JoinByNameExtensionMethods2.JoinByNameClass cfc;
                public VR1(global::CSharpProject.JoinByNameExtensionMethods2.JoinByNameClass cfc)
                {
                    this.cfc = cfc;
                }
                [DIVEX.Core.InvokeIndexAttribute(0)]
                public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
                {
                    this.cfc.Invoke<a>(folderPath, getFileSize, httpPost, httpPut, readFile, log, getFiles);
                }
            
            }
        
        }
    }
    
}


namespace CSharpProject
{
    public static partial class Program
    {
        public sealed partial class DelFunc
        {
        
            [DIVEX.Core.DelFuncAttribute(typeof(global::CSharpProject.Program.DelFunc.Adapters.DF1))]
            public  delegate void DF1(global::System.String message);
            public static partial class Adapters
            {
            
                [DIVEX.Core.DelegateAdapterClassAttribute()]
                public sealed class DF1
                {
                
                    public static implicit operator CSharpProject.Program.DelFunc.Adapters.DF1(CSharpProject.Program.DelFunc.DF1 @delegate)
                    {
                        return new DF1(@delegate);
                    }
                    public readonly CSharpProject.Program.DelFunc.DF1 @delegate;
                    public DF1(CSharpProject.Program.DelFunc.DF1 @delegate)
                    {
                        this.@delegate = @delegate;
                    }
                    [DIVEX.Core.InvokeIndexAttribute(0)]
                    public void Invoke(global::System.String message)
                    {
                        this.@delegate(message);
                    }
                
                }
            
            }
        
        }
        public sealed partial class DelFunc
        {
        
            [DIVEX.Core.DelFuncAttribute(typeof(global::CSharpProject.Program.DelFunc.Adapters.DF2))]
            public  delegate global::System.String[] DF2(global::System.String folder, global::System.IO.SearchOption searchOptions);
            public static partial class Adapters
            {
            
                [DIVEX.Core.DelegateAdapterClassAttribute()]
                public sealed class DF2
                {
                
                    public static implicit operator CSharpProject.Program.DelFunc.Adapters.DF2(CSharpProject.Program.DelFunc.DF2 @delegate)
                    {
                        return new DF2(@delegate);
                    }
                    public readonly CSharpProject.Program.DelFunc.DF2 @delegate;
                    public DF2(CSharpProject.Program.DelFunc.DF2 @delegate)
                    {
                        this.@delegate = @delegate;
                    }
                    [DIVEX.Core.InvokeIndexAttribute(0)]
                    public global::System.String[] Invoke(global::System.String folder, global::System.IO.SearchOption searchOptions)
                    {
                        return this.@delegate(folder, searchOptions);
                    }
                
                }
            
            }
        
        }
        public sealed partial class DelFunc
        {
        
            [DIVEX.Core.DelFuncAttribute(typeof(global::CSharpProject.Program.DelFunc.Adapters.DF3))]
            public  delegate global::System.Int64 DF3(global::System.String filename);
            public static partial class Adapters
            {
            
                [DIVEX.Core.DelegateAdapterClassAttribute()]
                public sealed class DF3
                {
                
                    public static implicit operator CSharpProject.Program.DelFunc.Adapters.DF3(CSharpProject.Program.DelFunc.DF3 @delegate)
                    {
                        return new DF3(@delegate);
                    }
                    public readonly CSharpProject.Program.DelFunc.DF3 @delegate;
                    public DF3(CSharpProject.Program.DelFunc.DF3 @delegate)
                    {
                        this.@delegate = @delegate;
                    }
                    [DIVEX.Core.InvokeIndexAttribute(0)]
                    public global::System.Int64 Invoke(global::System.String filename)
                    {
                        return this.@delegate(filename);
                    }
                
                }
            
            }
        
        }
        public sealed partial class DelFunc
        {
        
            [DIVEX.Core.DelFuncAttribute(typeof(global::CSharpProject.Program.DelFunc.Adapters.DF4))]
            public  delegate void DF4(global::System.Uri serverUri, global::System.String message);
            public static partial class Adapters
            {
            
                [DIVEX.Core.DelegateAdapterClassAttribute()]
                public sealed class DF4
                {
                
                    public static implicit operator CSharpProject.Program.DelFunc.Adapters.DF4(CSharpProject.Program.DelFunc.DF4 @delegate)
                    {
                        return new DF4(@delegate);
                    }
                    public readonly CSharpProject.Program.DelFunc.DF4 @delegate;
                    public DF4(CSharpProject.Program.DelFunc.DF4 @delegate)
                    {
                        this.@delegate = @delegate;
                    }
                    [DIVEX.Core.InvokeIndexAttribute(0)]
                    public void Invoke(global::System.Uri serverUri, global::System.String message)
                    {
                        this.@delegate(serverUri, message);
                    }
                
                }
            
            }
        
        }
        public sealed partial class DelFunc
        {
        
            [DIVEX.Core.DelFuncAttribute(typeof(global::CSharpProject.Program.DelFunc.Adapters.DF5))]
            public  delegate void DF5(global::System.Uri serverUri, global::System.String message);
            public static partial class Adapters
            {
            
                [DIVEX.Core.DelegateAdapterClassAttribute()]
                public sealed class DF5
                {
                
                    public static implicit operator CSharpProject.Program.DelFunc.Adapters.DF5(CSharpProject.Program.DelFunc.DF5 @delegate)
                    {
                        return new DF5(@delegate);
                    }
                    public readonly CSharpProject.Program.DelFunc.DF5 @delegate;
                    public DF5(CSharpProject.Program.DelFunc.DF5 @delegate)
                    {
                        this.@delegate = @delegate;
                    }
                    [DIVEX.Core.InvokeIndexAttribute(0)]
                    public void Invoke(global::System.Uri serverUri, global::System.String message)
                    {
                        this.@delegate(serverUri, message);
                    }
                
                }
            
            }
        
        }
        public sealed partial class DelFunc
        {
        
            [DIVEX.Core.DelFuncAttribute(typeof(global::CSharpProject.Program.DelFunc.Adapters.DF6))]
            public  delegate global::System.Byte[] DF6(global::System.String filename);
            public static partial class Adapters
            {
            
                [DIVEX.Core.DelegateAdapterClassAttribute()]
                public sealed class DF6
                {
                
                    public static implicit operator CSharpProject.Program.DelFunc.Adapters.DF6(CSharpProject.Program.DelFunc.DF6 @delegate)
                    {
                        return new DF6(@delegate);
                    }
                    public readonly CSharpProject.Program.DelFunc.DF6 @delegate;
                    public DF6(CSharpProject.Program.DelFunc.DF6 @delegate)
                    {
                        this.@delegate = @delegate;
                    }
                    [DIVEX.Core.InvokeIndexAttribute(0)]
                    public global::System.Byte[] Invoke(global::System.String filename)
                    {
                        return this.@delegate(filename);
                    }
                
                }
            
            }
        
        }
    }
    
}
            

namespace CSharpProject
{
    public static partial class Program
{
    [DIVEX.Core.OriginalClassTypeAttribute(typeof(global::FSharpProject.FSharpModule2))]
public static partial class SurrogateClassForFSharpModule2
{
    public static CSharpProject.Program.SurrogateClassForFSharpModule2.processFolderToFunctionClass processFolder
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFSharpModule2.processFolderToFunctionClass();
        }
    }
    public static CSharpProject.Program.SurrogateClassForFSharpModule2.logToFileToFunctionClass logToFile
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFSharpModule2.logToFileToFunctionClass();
        }
    }
    public static CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass processFile
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass();
        }
    }
    public static CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass recordFileSize
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass();
        }
    }
    public static CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass uploadFile
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass();
        }
    }
    public static CSharpProject.Program.SurrogateClassForFSharpModule2.getFilesToFunctionClass getFiles
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFSharpModule2.getFilesToFunctionClass();
        }
    }
    public static CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass getFileSize
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass();
        }
    }
    public static CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass httpPost
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass();
        }
    }
    public static CSharpProject.Program.SurrogateClassForFSharpModule2.httpPutToFunctionClass httpPut
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFSharpModule2.httpPutToFunctionClass();
        }
    }

    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "processFolder")]
    public sealed class processFolderToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("processFolder", 1, "a", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>", "System.Boolean", "Microsoft.FSharp.Core.FSharpFunc<a, Microsoft.FSharp.Core.FSharpFunc<System.IO.SearchOption, System.String[]>>")]
        public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate processFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, global::System.Boolean processSubFolders, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
        {
            global::FSharpProject.FSharpModule2.processFolder<a>(folderPath, (processFile is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(processFile), (log is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(log), processSubFolders, (getFiles is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>(getFiles));
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "logToFile")]
    public sealed class logToFileToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("logToFile", 0, "System.String", "System.String")]
        public void Invoke(global::System.String message, global::System.String filename)
        {
            global::FSharpProject.FSharpModule2.logToFile(message, filename);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "processFile")]
    public sealed class processFileToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("processFile", 2, "System.String", "Microsoft.FSharp.Core.FSharpFunc<System.String, a>", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.FSharpFunc<a, b>>", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>")]
        public b Invoke<a, b>(global::System.String filename, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, a>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, a, b>.Delegate recordFileSize, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate uploadFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
        {
            return global::FSharpProject.FSharpModule2.processFile<a,b>(filename, (getFileSize is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, a>(getFileSize), (recordFileSize is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, a, b>(recordFileSize), (uploadFile is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(uploadFile), (log is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(log));
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "recordFileSize")]
    public sealed class recordFileSizeToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("recordFileSize", 1, "System.String", "System.Int64", "Microsoft.FSharp.Core.FSharpFunc<System.Uri, Microsoft.FSharp.Core.FSharpFunc<System.String, a>>", "System.Uri")]
        public a Invoke<a>(global::System.String filename, global::System.Int64 size, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>.Delegate httpPost, global::System.Uri serverUrl)
        {
            return global::FSharpProject.FSharpModule2.recordFileSize<a>(filename, size, (httpPost is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>(httpPost), serverUrl);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "uploadFile")]
    public sealed class uploadFileToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("uploadFile", 1, "System.String", "System.Uri", "System.Boolean", "Microsoft.FSharp.Core.FSharpFunc<System.Uri, Microsoft.FSharp.Core.FSharpFunc<System.String, a>>", "Microsoft.FSharp.Core.FSharpFunc<System.Uri, Microsoft.FSharp.Core.FSharpFunc<System.String, a>>", "Microsoft.FSharp.Core.FSharpFunc<System.String, System.Byte[]>")]
        public a Invoke<a>(global::System.String filename, global::System.Uri serverUrl, global::System.Boolean useHttpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>.Delegate httpPut, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>.Delegate readFile)
        {
            return global::FSharpProject.FSharpModule2.uploadFile<a>(filename, serverUrl, useHttpPut, (httpPost is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>(httpPost), (httpPut is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.Uri, global::System.String, a>(httpPut), (readFile is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Byte[]>(readFile));
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "getFiles")]
    public sealed class getFilesToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("getFiles", 0, "System.String", "System.IO.SearchOption")]
        public global::System.String[] Invoke(global::System.String folderPath, global::System.IO.SearchOption searchOption)
        {
            return global::FSharpProject.FSharpModule2.getFiles(folderPath, searchOption);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "getFileSize")]
    public sealed class getFileSizeToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("getFileSize", 0, "System.String")]
        public global::System.Int64 Invoke(global::System.String filename)
        {
            return global::FSharpProject.FSharpModule2.getFileSize(filename);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "httpPost")]
    public sealed class httpPostToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("httpPost", 0, "System.Uri", "System.String", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>")]
        public void Invoke(global::System.Uri serverUrl, global::System.String message, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
        {
            global::FSharpProject.FSharpModule2.httpPost(serverUrl, message, (log is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(log));
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "httpPut")]
    public sealed class httpPutToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("httpPut", 0, "System.Uri", "System.String", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>")]
        public void Invoke(global::System.Uri serverUrl, global::System.String message, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
        {
            global::FSharpProject.FSharpModule2.httpPut(serverUrl, message, (log is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(log));
        }
    
    }

}
[DIVEX.Core.OriginalClassTypeAttribute(typeof(global::System.IO.File))]
public static partial class SurrogateClassForFile
{
    public static CSharpProject.Program.SurrogateClassForFile.ReadAllBytesToFunctionClass ReadAllBytes
    {
        get
        {
            return new CSharpProject.Program.SurrogateClassForFile.ReadAllBytesToFunctionClass();
        }
    }

    [DIVEX.Core.FunctionReferenceClassAttribute("System.IO.File", "ReadAllBytes")]
    public sealed class ReadAllBytesToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("ReadAllBytes", 0, "System.String")]
        public global::System.Byte[] Invoke(global::System.String path)
        {
            return global::System.IO.File.ReadAllBytes(path);
        }
    
    }

}
}
}

#endregion
