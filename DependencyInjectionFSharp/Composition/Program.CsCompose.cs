using System;
using FSharpProject;
using static FSharpProject.FSharpModule;
using DIVEX.Core;

namespace DependencyInjectionFSharp
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
            var programPotentiallyPure = SurrogateClassForFSharpModule.program.Set(readStrings: SurrogateClassForFSharpModule.askUserForStrings).Set(compare: SurrogateClassForFSharpModule.compareTwoStrings).Set(writeResult: SurrogateClassForFSharpModule.writeResult).JoinAllInputs();
            var programImpure = programPotentiallyPure.Set(readLn: ((DelFunc.DF1)(() => Console.ReadLine()))).Set(writeLn: str => Console.WriteLine(str)).Set(log: msg => Console.WriteLine("Log: " + msg));
            programImpure.Invoke();
        }
    }
}
#region DIVEX code

namespace DependencyInjectionFSharp
{
    
    public static class JoinAllInputsExtensionMethods1
    {
    
        public static DependencyInjectionFSharp.JoinAllInputsExtensionMethods1.JoinAllInputsClass JoinAllInputs(this global::DependencyInjectionFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass function)
        {
            return new JoinAllInputsClass(function);
        }
        [DIVEX.Core.JoinAllInputsClassAttribute("function")]
        public sealed class JoinAllInputsClass
        {
        
            public readonly global::DependencyInjectionFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass function;
            public JoinAllInputsClass(global::DependencyInjectionFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass function)
            {
                this.function = function;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.JoinedParametersDetailsAttribute("0,(1;3),2")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$")]
            public void Invoke<a>(global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter0<a>.Delegate readLn, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate writeLn, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
            {
                this.function.Invoke<a>(new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter0<a>.Delegate(readLn),new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate(writeLn),new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate(log),new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate(writeLn));
            }
        
        }
    
    }
}

namespace DependencyInjectionFSharp
{
    
    public static class SetExtensionMethods1
    {
    
        public static global::DependencyInjectionFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.InjectClass Set(this global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.programToFunctionClass f1, global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.askUserForStringsToFunctionClass readStrings)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.askUserForStringsToFunctionClass, global::DIVEX.Core.Indexes.Index.I0>(readStrings));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DependencyInjectionFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.InjectClass Inject(global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.programToFunctionClass f1, global::DIVEX.Core.ValueByIndex<global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.askUserForStringsToFunctionClass, global::DIVEX.Core.Indexes.Index.I0> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.programToFunctionClass f1;
            public readonly global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.askUserForStringsToFunctionClass f2;
            public InjectClass(global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.programToFunctionClass f1, global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.askUserForStringsToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute()]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$0$", "$0$", "$1$", "$2$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2, "$0$")]
            public d Invoke<a, c, d>(global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter0<a>.Delegate readLn, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate writeLn, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, a, c>.Delegate compare, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<c, d>.Delegate writeResult)
            {
                return this.f1.Invoke<a, a, c, d>(() => this.f2.Invoke<a>(readLn, writeLn), compare, writeResult);
            }
        
        }
    
    }
    
    }
}

namespace DependencyInjectionFSharp
{
    
    public static class SetExtensionMethods2
    {
    
        public static global::DependencyInjectionFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.InjectClass Set(this global::DependencyInjectionFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.InjectClass f1, global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.compareTwoStringsToFunctionClass compare)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.compareTwoStringsToFunctionClass, global::DIVEX.Core.Indexes.Index.I2>(compare));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DependencyInjectionFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.InjectClass Inject(global::DependencyInjectionFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.compareTwoStringsToFunctionClass, global::DIVEX.Core.Indexes.Index.I2> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DependencyInjectionFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.compareTwoStringsToFunctionClass f2;
            public InjectClass(global::DependencyInjectionFSharp.SetExtensionMethods1.ContainerForDivexSetArg1.InjectClass f1, global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.compareTwoStringsToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0,1)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "$1$", "global::FSharpProject.FSharpModule.ComparisonResult", "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2, "$1$")]
            public d Invoke<d, a>(global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter0<a>.Delegate readLn, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate writeLn, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<global::FSharpProject.FSharpModule.ComparisonResult, d>.Delegate writeResult)
            {
                return this.f1.Invoke<a, global::FSharpProject.FSharpModule.ComparisonResult, d>(readLn, writeLn, (arg1, arg2) => this.f2.Invoke<a>(arg1, arg2, log), writeResult);
            }
        
        }
    
    }
    
    }
}

namespace DependencyInjectionFSharp
{
    
    public static class SetExtensionMethods3
    {
    
        public static global::DependencyInjectionFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass Set(this global::DependencyInjectionFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.InjectClass f1, global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.writeResultToFunctionClass writeResult)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.writeResultToFunctionClass, global::DIVEX.Core.Indexes.Index.I3>(writeResult));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DependencyInjectionFSharp.SetExtensionMethods3.ContainerForDivexSetArg1.InjectClass Inject(global::DependencyInjectionFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.ValueByIndex<global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.writeResultToFunctionClass, global::DIVEX.Core.Indexes.Index.I3> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DependencyInjectionFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.InjectClass f1;
            public readonly global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.writeResultToFunctionClass f2;
            public InjectClass(global::DependencyInjectionFSharp.SetExtensionMethods2.ContainerForDivexSetArg1.InjectClass f1, global::DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.writeResultToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "global::DIVEX.Core.Unit", "$0$")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke<a>(global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter0<a>.Delegate readLn, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate writeLn, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log, [DIVEX.Core.ParameterNameAttribute("writeLn")]global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate writeLn1)
            {
                this.f1.Invoke<global::DIVEX.Core.Unit, a>(readLn, writeLn, log, arg1 =>
                {
                    this.f2.Invoke(arg1, writeLn1);
                    return null;
                });
            }
        
        }
    
    }
    
    }
}

namespace DependencyInjectionFSharp
{
    
    public static class SetExtensionMethods4
    {
    
        public static global::DependencyInjectionFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.InjectClass Set(this global::DependencyInjectionFSharp.JoinAllInputsExtensionMethods1.JoinAllInputsClass f1, global::DependencyInjectionFSharp.Program.DelFunc.DF1 readLn)
        {
            return ContainerForDivexSetArg1.Inject(f1, new global::DIVEX.Core.ValueByIndex<global::DependencyInjectionFSharp.Program.DelFunc.DF1, global::DIVEX.Core.Indexes.Index.I0>(readLn));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DependencyInjectionFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.InjectClass Inject(global::DependencyInjectionFSharp.JoinAllInputsExtensionMethods1.JoinAllInputsClass f1, global::DIVEX.Core.ValueByIndex<global::DependencyInjectionFSharp.Program.DelFunc.DF1, global::DIVEX.Core.Indexes.Index.I0> arg)
        {
            return new InjectClass(f1, arg.Value);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DependencyInjectionFSharp.JoinAllInputsExtensionMethods1.JoinAllInputsClass f1;
            public readonly global::DependencyInjectionFSharp.Program.DelFunc.Adapters.DF1 f2;
            public InjectClass(global::DependencyInjectionFSharp.JoinAllInputsExtensionMethods1.JoinAllInputsClass f1, global::DependencyInjectionFSharp.Program.DelFunc.Adapters.DF1 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute()]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1, "global::System.String")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate writeLn, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
            {
                this.f1.Invoke<global::System.String>(() => this.f2.Invoke(), writeLn, log);
            }
        
        }
    
    }
    
    }
}

namespace DependencyInjectionFSharp
{
    
    public static class SetExtensionMethods5
    {
    
        public static global::DependencyInjectionFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass Set(this global::DependencyInjectionFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.InjectClass f1, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate writeLn)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate, global::DIVEX.Core.Indexes.Index.I0>(writeLn));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DependencyInjectionFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass Apply(global::DependencyInjectionFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.InjectClass function, global::DIVEX.Core.ValueByIndex<global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate, global::DIVEX.Core.Indexes.Index.I0> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::DependencyInjectionFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.InjectClass function;
            public readonly global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate input1;
            public ApplyClass(global::DependencyInjectionFSharp.SetExtensionMethods4.ContainerForDivexSetArg1.InjectClass function, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(0)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public void Invoke(global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
            {
                this.function.Invoke(this.input1, log);
            }
        
        }
    
    }
    
    }
}

namespace DependencyInjectionFSharp
{
    
    public static class SetExtensionMethods6
    {
    
        public static global::DependencyInjectionFSharp.SetExtensionMethods6.ContainerForDivexSetArg1.ApplyClass Set(this global::DependencyInjectionFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass f1, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
        {
            return ContainerForDivexSetArg1.Apply(f1, new global::DIVEX.Core.ValueByIndex<global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate, global::DIVEX.Core.Indexes.Index.I0>(log));
        }
    
    
    public static class ContainerForDivexSetArg1
    {
    
        public static DependencyInjectionFSharp.SetExtensionMethods6.ContainerForDivexSetArg1.ApplyClass Apply(global::DependencyInjectionFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass function, global::DIVEX.Core.ValueByIndex<global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate, global::DIVEX.Core.Indexes.Index.I0> arg)
        {
            return new ApplyClass(function, arg.Value);
        }
        [DIVEX.Core.ApplyClassAttribute("function", "input1")]
        public sealed class ApplyClass
        {
        
            public readonly global::DependencyInjectionFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass function;
            public readonly global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate input1;
            public ApplyClass(global::DependencyInjectionFSharp.SetExtensionMethods5.ContainerForDivexSetArg1.ApplyClass function, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate input1)
            {
                this.function = function;
                this.input1 = input1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ApplyMapAttribute(0)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public void Invoke()
            {
                this.function.Invoke(this.input1);
            }
        
        }
    
    }
    
    }
}



namespace DependencyInjectionFSharp
{
    public static partial class Program
    {
        public sealed partial class DelFunc
        {
        
            [DIVEX.Core.DelFuncAttribute(typeof(global::DependencyInjectionFSharp.Program.DelFunc.Adapters.DF1))]
            public  delegate global::System.String DF1();
            public static partial class Adapters
            {
            
                [DIVEX.Core.DelegateAdapterClassAttribute()]
                public sealed class DF1
                {
                
                    public static implicit operator DependencyInjectionFSharp.Program.DelFunc.Adapters.DF1(DependencyInjectionFSharp.Program.DelFunc.DF1 @delegate)
                    {
                        return new DF1(@delegate);
                    }
                    public readonly DependencyInjectionFSharp.Program.DelFunc.DF1 @delegate;
                    public DF1(DependencyInjectionFSharp.Program.DelFunc.DF1 @delegate)
                    {
                        this.@delegate = @delegate;
                    }
                    [DIVEX.Core.InvokeIndexAttribute(0)]
                    public global::System.String Invoke()
                    {
                        return this.@delegate();
                    }
                
                }
            
            }
        
        }
    }
    
}
            

namespace DependencyInjectionFSharp
{
    public static partial class Program
{
    [DIVEX.Core.OriginalClassTypeAttribute(typeof(global::FSharpProject.FSharpModule))]
public static partial class SurrogateClassForFSharpModule
{
    public static DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.askUserForStringsToFunctionClass askUserForStrings
    {
        get
        {
            return new DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.askUserForStringsToFunctionClass();
        }
    }
    public static DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.compareTwoStringsToFunctionClass compareTwoStrings
    {
        get
        {
            return new DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.compareTwoStringsToFunctionClass();
        }
    }
    public static DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.writeResultToFunctionClass writeResult
    {
        get
        {
            return new DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.writeResultToFunctionClass();
        }
    }
    public static DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.programToFunctionClass program
    {
        get
        {
            return new DependencyInjectionFSharp.Program.SurrogateClassForFSharpModule.programToFunctionClass();
        }
    }

    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "askUserForStrings")]
    public sealed class askUserForStringsToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("askUserForStrings", 1, "Microsoft.FSharp.Core.FSharpFunc<Microsoft.FSharp.Core.Unit, a>", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>")]
        public global::System.Tuple<a, a> Invoke<a>(global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter0<a>.Delegate readLn, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate writeLn)
        {
            return global::FSharpProject.FSharpModule.askUserForStrings<a>((readLn is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter0<a>(readLn), (writeLn is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(writeLn));
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "compareTwoStrings")]
    public sealed class compareTwoStringsToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("compareTwoStrings", 1, "a", "a", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>")]
        public global::FSharpProject.FSharpModule.ComparisonResult Invoke<a>(a str1, a str2, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate log)
        {
            return global::FSharpProject.FSharpModule.compareTwoStrings<a>(str1, str2, (log is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(log));
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "writeResult")]
    public sealed class writeResultToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("writeResult", 0, "FSharpProject.FSharpModule.ComparisonResult", "Microsoft.FSharp.Core.FSharpFunc<System.String, Microsoft.FSharp.Core.Unit>")]
        public void Invoke(global::FSharpProject.FSharpModule.ComparisonResult result, global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>.Delegate writeLn)
        {
            global::FSharpProject.FSharpModule.writeResult(result, (writeLn is null) ? null : new global::DIVEX.Core.FSharp.Adapters.NoOutput.Adapter1<global::System.String>(writeLn));
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("FSharpProject.FSharpModule", "program")]
    public sealed class programToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("program", 4, "Microsoft.FSharp.Core.FSharpFunc<Microsoft.FSharp.Core.Unit, System.Tuple<a, b>>", "Microsoft.FSharp.Core.FSharpFunc<a, Microsoft.FSharp.Core.FSharpFunc<b, c>>", "Microsoft.FSharp.Core.FSharpFunc<c, d>")]
        public d Invoke<a, b, c, d>(global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter0<global::System.Tuple<a, b>>.Delegate readStrings, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, b, c>.Delegate compare, global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<c, d>.Delegate writeResult)
        {
            return global::FSharpProject.FSharpModule.program<a,b,c,d>((readStrings is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter0<global::System.Tuple<a, b>>(readStrings), (compare is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter2<a, b, c>(compare), (writeResult is null) ? null : new global::DIVEX.Core.FSharp.Adapters.WithOutput.Adapter1<c, d>(writeResult));
        }
    
    }

}
}
}

#endregion
