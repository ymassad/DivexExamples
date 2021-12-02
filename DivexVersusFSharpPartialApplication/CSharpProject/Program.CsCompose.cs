using System;
using DIVEX.Core;
using static FSharpProject.FSharpModule2;

namespace CSharpProject
{
    [DivexCompose]
    public static partial class Program
    {
        [DIVEX.Core.FunctionsClassAttribute(typeof(global::FSharpProject.FSharpModule2))]
        public static partial class SurrogateClassForFSharpModule2
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
            var processFolderPotentiallyPure = SurrogateClassForFSharpModule2.processFolder.Set(processSubFolders: true).Set(processFile: SurrogateClassForFSharpModule2.processFile).Set(recordFileSize: SurrogateClassForFSharpModule2.recordFileSize.Set(serverUrl: "https://server1.demo")).Set(uploadFile: SurrogateClassForFSharpModule2.uploadFile.Set(serverUrl: "https://server2.demo", useHttpPut: false)).JoinByName(log: 0);
            var log = SurrogateClassForFSharpModule2.logToFile.Set(filename: "c:\\log1.txt");
            var httpPost1 = SurrogateClassForFSharpModule2.httpPost.Set(log: log);
            var processFolderImpure = processFolderPotentiallyPure.Set(log: log).Set(getFileSize: SurrogateClassForFSharpModule2.getFileSize).Set(httpPost: httpPost1);
        }
    }
}
#region DIVEX code

namespace CSharpProject
{
    
    public static class JoinByNameExtensionMethods1
    {
    
        public static CSharpProject.JoinByNameExtensionMethods1.JoinByNameClass JoinByName(this global::CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass function, global::System.Object log)
        {
            return new JoinByNameClass(function);
        }
        [DIVEX.Core.JoinByNameClassAttribute("function", "log")]
        public sealed class JoinByNameClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass function;
            public JoinByNameClass(global::CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass function)
            {
                this.function = function;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.JoinedParametersDetailsAttribute("0,1,2,(3;4),5")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.function.Invoke<a>(folderPath,new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate(getFileSize),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, global::System.String, global::DIVEX.Core.Unit>.Delegate(httpPost),new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate(log),new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate(log),new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate(getFiles));
            }
        
        }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods1
    {
    
        public static global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFolderToFunctionClass f1, global::System.Boolean processSubFolders)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.Boolean, global::DIVEX.Core.Indexes.Index.I3>(processSubFolders));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass Apply(global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFolderToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.Boolean, global::DIVEX.Core.Indexes.Index.I3> arg)
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
    
    public static class SetExtensionMethods2
    {
    
        public static global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass f1, global::System.String serverUrl)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I3>(serverUrl));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass Apply(global::CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I3> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::CSharpProject.Program.SurrogateClassForFSharpModule2.recordFileSizeToFunctionClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "global::System.String", "$0$")]
            public b Invoke<b>(global::System.String filename, global::System.Int64 size, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, global::System.String, b>.Delegate httpPost)
            {
                return this.function.Invoke<global::System.String, b>(filename, size, httpPost, this.input1);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods3
    {
    
        public static global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg2.ApplyClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass f1, global::System.String serverUrl, global::System.Boolean useHttpPut)
        {
            return ContainerForDivexSetArg2.Apply(ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(serverUrl)), new global::DIVEX.Core.ValueByIndex<global::System.Boolean, global::DIVEX.Core.Indexes.Index.I1>(useHttpPut));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass Apply(global::CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::CSharpProject.Program.SurrogateClassForFSharpModule2.uploadFileToFunctionClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public void Invoke(global::System.String filename, global::System.Boolean useHttpPut)
            {
                this.function.Invoke(filename, this.input1, useHttpPut);
            }
        
        }
    
    }
    
    
    public static class ContainerForDivexSetArg2
    {
    
        public static CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg2.ApplyClass Apply(global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass function, global::DIVEX.Core.ValueByIndex<global::System.Boolean, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass function;
            public readonly global::System.Boolean input1;
            public ApplyClass(global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg1.ApplyClass function, global::System.Boolean input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public void Invoke(global::System.String filename)
            {
                this.function.Invoke(filename, this.input1);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods4
    {
    
        public static global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.logToFileToFunctionClass f1, global::System.String filename)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(filename));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass Apply(global::CSharpProject.Program.SurrogateClassForFSharpModule2.logToFileToFunctionClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
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
    
    public static class SetExtensionMethods5
    {
    
        public static global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass processFile)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass, global::DIVEX.Core.Indexes.Index.I1>(processFile));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f1;
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods1.ContainerForDivexSetArg1.ApplyClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.processFileToFunctionClass f2)
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
    
        public static global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass recordFileSize)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2>(recordFileSize));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods5.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods2.ContainerForDivexSetArg1.ApplyClass f2)
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
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate uploadFile, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, [DIVEX.Core.ParameterNameAttribute("log")]global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log1, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a, global::System.Int64>(folderPath, getFileSize, (arg1, arg2) => this.f2.Invoke<global::DIVEX.Core.Unit>(arg1, arg2, httpPost), uploadFile, log, log1, getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods7
    {
    
        public static global::CSharpProject.SetExtensionMethods7.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass f1, global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass log)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2>(log));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods7.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass f1;
            public readonly global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::CSharpProject.Program.SurrogateClassForFSharpModule2.httpPostToFunctionClass f1, global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass f2)
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
            public void Invoke(global::System.String serverUrl, global::System.String message)
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
    
        public static global::CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg2.ApplyClass uploadFile)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg2.ApplyClass, global::DIVEX.Core.Indexes.Index.I3>(uploadFile));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods8.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg2.ApplyClass, global::DIVEX.Core.Indexes.Index.I3> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg2.ApplyClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods6.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.SetExtensionMethods3.ContainerForDivexSetArg2.ApplyClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, [DIVEX.Core.ParameterNameAttribute("log")]global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log1, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, getFileSize, httpPost, arg1 => this.f2.Invoke(arg1), log, log1, getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods9
    {
    
        public static global::CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.JoinByNameExtensionMethods1.JoinByNameClass f1, global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass log)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I3>(log));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.JoinByNameExtensionMethods1.JoinByNameClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass, global::DIVEX.Core.Indexes.Index.I3> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.JoinByNameExtensionMethods1.JoinByNameClass f1;
            public readonly global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass f2;
            public InjectClass(global::CSharpProject.JoinByNameExtensionMethods1.JoinByNameClass f1, global::CSharpProject.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::System.String, global::System.Int64>.Delegate getFileSize, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, getFileSize, httpPost, arg1 => this.f2.Invoke(arg1), getFiles);
            }
        
        }
    
    }
    
    }
}

namespace CSharpProject
{
    
    public static class SetExtensionMethods10
    {
    
        public static global::CSharpProject.SetExtensionMethods10.ContainerForDivexSetArg1.InjectClass Set(this global::CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass getFileSize)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass, global::DIVEX.Core.Indexes.Index.I1>(getFileSize));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static CSharpProject.SetExtensionMethods10.ContainerForDivexSetArg1.InjectClass Inject(global::CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass f2;
            public InjectClass(global::CSharpProject.SetExtensionMethods9.ContainerForDivexSetArg1.InjectClass f1, global::CSharpProject.Program.SurrogateClassForFSharpModule2.getFileSizeToFunctionClass f2)
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
            public void Invoke<a>(a folderPath, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<global::System.String, global::System.String, global::DIVEX.Core.Unit>.Delegate httpPost, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.IO.SearchOption, global::System.String[]>.Delegate getFiles)
            {
                this.f1.Invoke<a>(folderPath, arg1 => this.f2.Invoke(arg1), httpPost, getFiles);
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
        [DIVEX.Core.OriginalMethodAttribute("recordFileSize", 2, "System.String", "System.Int64", "Microsoft.FSharp.Core.FSharpFunc<a, Microsoft.FSharp.Core.FSharpFunc<System.String, b>>", "a")]
        public b Invoke<a, b>(global::System.String filename, global::System.Int64 size, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.String, b>.Delegate httpPost, a serverUrl)
        {
            return global::FSharpProject.FSharpModule2.recordFileSize<a,b>(filename, size, (httpPost is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, global::System.String, b>(httpPost), serverUrl);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule2", "uploadFile")]
    public sealed class uploadFileToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("uploadFile", 0, "System.String", "System.String", "System.Boolean")]
        public void Invoke(global::System.String filename, global::System.String serverUrl, global::System.Boolean useHttpPut)
        {
            global::FSharpProject.FSharpModule2.uploadFile(filename, serverUrl, useHttpPut);
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
        [DIVEX.Core.OriginalMethodAttribute("httpPost", 0, "System.String", "System.String", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>")]
        public void Invoke(global::System.String serverUrl, global::System.String message, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
        {
            global::FSharpProject.FSharpModule2.httpPost(serverUrl, message, (log is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(log));
        }
    
    }

}
}
}

#endregion
