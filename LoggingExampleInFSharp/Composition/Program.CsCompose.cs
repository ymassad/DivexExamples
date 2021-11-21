using System;
using FSharpProject;
using static FSharpProject.FSharpModule;
using DIVEX.Core;

namespace Composition
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
            var logToFile1 = SurrogateClassForFSharpModule.logToFile.Set(filename_logFilename: 0); //Renaming parameter to make more sense after composition
            var processOrderAndLogToConsole = SurrogateClassForFSharpModule.processOrderAndLog.Set(SurrogateClassForFSharpModule.logToConsole.ByType());
            var processOrderAndLogToFile = SurrogateClassForFSharpModule.processOrderAndLog.Set(logToFile1.ByType());
            var processOrderAndLogToLog1DotTxt = processOrderAndLogToFile.Set(logFilename: "c:\\log1.txt");
            var processOrderAndLogToLog2DotTxt = processOrderAndLogToFile.Set(logFilename: "c:\\log2.txt");
            var order = new Order(2);
            processOrderAndLogToConsole.Invoke(order);
            processOrderAndLogToLog1DotTxt.Invoke(order);
            processOrderAndLogToLog2DotTxt.Invoke(order);
        }
    }
}
#region DIVEX code

namespace Composition
{
    
    public static class SetExtensionMethods1
    {
    
        public static global::Composition.SetExtensionMethods1.ContainerForDivexSetArg1.RenameClass Set(this global::Composition.Program.SurrogateClassForFSharpModule.logToFileToFunctionClass f1, global::System.Int32 filename_logFilename)
        {
            return ContainerForDivexSetArg1.Rename(f1, filename_logFilename: 0);
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static Composition.SetExtensionMethods1.ContainerForDivexSetArg1.RenameClass Rename(global::Composition.Program.SurrogateClassForFSharpModule.logToFileToFunctionClass f1, global::System.Object filename_logFilename)
        {
            return new RenameClass(f1);
        }
        [DIVEX.Core.RenameClassAttribute("f1", "logFilename")]
        public sealed class RenameClass
        {
        
            public readonly global::Composition.Program.SurrogateClassForFSharpModule.logToFileToFunctionClass f1;
            public RenameClass(global::Composition.Program.SurrogateClassForFSharpModule.logToFileToFunctionClass f1)
            {
                this.f1 = f1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            public void Invoke(global::System.String msg, global::System.String logFilename)
            {
                this.f1.Invoke(msg, logFilename);
            }
        
        }
    
    }
    
    }
}

namespace Composition
{
    
    public static class SetExtensionMethods2
    {
    
        public static global::Composition.SetExtensionMethods2.ContainerForDivexSetArg1.InjectClass Set(this global::Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass f1, global::DIVEX.Core.ValueByType<global::Composition.Program.SurrogateClassForFSharpModule.logToConsoleToFunctionClass> arg0)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::Composition.Program.SurrogateClassForFSharpModule.logToConsoleToFunctionClass, global::DIVEX.Core.Indexes.Index.I1>(arg0.Value));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static Composition.SetExtensionMethods2.ContainerForDivexSetArg1.InjectClass Inject(global::Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass f1, global::DIVEX.Core.ValueByIndex<global::Composition.Program.SurrogateClassForFSharpModule.logToConsoleToFunctionClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass f1;
            public readonly global::Composition.Program.SurrogateClassForFSharpModule.logToConsoleToFunctionClass f2;
            public InjectClass(global::Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass f1, global::Composition.Program.SurrogateClassForFSharpModule.logToConsoleToFunctionClass f2)
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
            public void Invoke(global::FSharpProject.FSharpModule.Order order)
            {
                this.f1.Invoke(order, arg1 => this.f2.Invoke(arg1));
            }
        
        }
    
    }
    
    }
}

namespace Composition
{
    
    public static class SetExtensionMethods3
    {
    
        public static global::Composition.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass Set(this global::Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass f1, global::DIVEX.Core.ValueByType<global::Composition.SetExtensionMethods1.ContainerForDivexSetArg1.RenameClass> arg0)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::Composition.SetExtensionMethods1.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I1>(arg0.Value));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static Composition.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass Inject(global::Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass f1, global::DIVEX.Core.ValueByIndex<global::Composition.SetExtensionMethods1.ContainerForDivexSetArg1.RenameClass, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass f1;
            public readonly global::Composition.SetExtensionMethods1.ContainerForDivexSetArg1.RenameClass f2;
            public InjectClass(global::Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass f1, global::Composition.SetExtensionMethods1.ContainerForDivexSetArg1.RenameClass f2)
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
            public void Invoke(global::FSharpProject.FSharpModule.Order order, global::System.String logFilename)
            {
                this.f1.Invoke(order, arg1 => this.f2.Invoke(arg1, logFilename));
            }
        
        }
    
    }
    
    }
}

namespace Composition
{
    
    public static class SetExtensionMethods4
    {
    
        public static global::Composition.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass Set(this global::Composition.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass f1, global::System.String logFilename)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1>(logFilename));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static Composition.SetExtensionMethods4.ContainerForDivexSetArg1.ApplyClass Apply(global::Composition.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass function, global::DIVEX.Core.ValueByIndex<global::System.String, global::DIVEX.Core.Indexes.Index.I1> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::Composition.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass function;
            public readonly global::System.String input1;
            public ApplyClass(global::Composition.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass function, global::System.String input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public void Invoke(global::FSharpProject.FSharpModule.Order order)
            {
                this.function.Invoke(order, this.input1);
            }
        
        }
    
    }
    
    }
}





namespace Composition
{
    public static partial class Program
{
    [DIVEX.Core.OriginalClassTypeAttribute(typeof(global::FSharpProject.FSharpModule))]
public static partial class SurrogateClassForFSharpModule
{
    public static Composition.Program.SurrogateClassForFSharpModule.logToConsoleToFunctionClass logToConsole
    {
        get
        {
            return new Composition.Program.SurrogateClassForFSharpModule.logToConsoleToFunctionClass();
        }
    }
    public static Composition.Program.SurrogateClassForFSharpModule.logToFileToFunctionClass logToFile
    {
        get
        {
            return new Composition.Program.SurrogateClassForFSharpModule.logToFileToFunctionClass();
        }
    }
    public static Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass processOrderAndLog
    {
        get
        {
            return new Composition.Program.SurrogateClassForFSharpModule.processOrderAndLogToFunctionClass();
        }
    }

    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "logToConsole")]
    public sealed class logToConsoleToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("logToConsole", 0, "System.String")]
        public void Invoke(global::System.String msg)
        {
            global::FSharpProject.FSharpModule.logToConsole(msg);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "logToFile")]
    public sealed class logToFileToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("logToFile", 0, "System.String", "System.String")]
        public void Invoke(global::System.String msg, global::System.String filename)
        {
            global::FSharpProject.FSharpModule.logToFile(msg, filename);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "processOrderAndLog")]
    public sealed class processOrderAndLogToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("processOrderAndLog", 0, "FSharpProject.FSharpModule.Order", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>")]
        public void Invoke(global::FSharpProject.FSharpModule.Order order, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
        {
            global::FSharpProject.FSharpModule.processOrderAndLog(order, (log is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(log));
        }
    
    }

}
}
}

#endregion
