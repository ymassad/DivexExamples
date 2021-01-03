using DIVEX.Core;
using System;
using System.Collections.Generic;

namespace DivexDemo
{
    [DivexCompose]
    public partial class Program
    {
        public enum CompareResult { Bigger, Smaller, Equal }

        static void Main(string[] args)
        {
            DelFunc.DF1 readFromConsole = (Action<string> writeLn, Func<string> readLn) =>
            {
                writeLn("Enter the first value");
                var str1 = readLn();
                writeLn("Enter the second value");
                var str2 = readLn();
                return Tuple.Create(str1, str2);
            };

            DelFunc.F2 compareTwoStrings = (Action<string> log, string str1, string str2) =>
            {
                log("Comparing");

                if (str1.CompareTo(str2) > 0)
                    return CompareResult.Bigger;
                else if (str1.CompareTo(str2) < 0)
                    return CompareResult.Smaller;
                else
                    return CompareResult.Equal;
            };

            DelFunc.F3 writeToConsole = (CompareResult result, Action<string> writeLn) =>
            {
                if (result == CompareResult.Bigger)
                    writeLn("The first value is bigger");
                else if (result == CompareResult.Smaller)
                    writeLn("The first value is smaller");
                else if (result == CompareResult.Equal)
                    writeLn("The values are equal");
            };

            DelFunc.DF4 program = (Func<Tuple<string, string>> readStrings,
                Func<string, string, CompareResult> compare,
                Action<CompareResult> writeResult) =>
            {
                var (str1, str2) = readStrings();

                var compareResult = compare(str1, str2);

                writeResult(compareResult);
            };

            var programImpure = //Signature is ((string => ()) writeLn, (() => string) readLn, (string => ()) log, (string => ()) writeLn)
                program
                    .Inject(readStrings: readFromConsole)
                    .Inject(compare: compareTwoStrings)
                    .Inject(writeResult: writeToConsole);

            var programImpureJoined =
                programImpure.JoinByName(writeLn: 0); //Signature is ((string => ()) writeLn, (() => string) readLn, (string => ()) log)

            programImpureJoined
                .Invoke(
                    writeLn: Console.WriteLine,
                    readLn: Console.ReadLine,
                    log: x => Console.WriteLine("logging: " + x));
        }
    }
}
