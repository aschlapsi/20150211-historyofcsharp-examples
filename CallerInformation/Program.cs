using System;
using System.Runtime.CompilerServices;

namespace CallerInformation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.DoProcessing();
        }

        private void DoProcessing()
        {
            TraceMessage("DoProcessing");
        }

        private void TraceMessage(
            string message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            Console.WriteLine("message: " + message);
            Console.WriteLine("member name: " + memberName);
            Console.WriteLine("source file path: " + sourceFilePath);
            Console.WriteLine("source line number: " + sourceLineNumber);
        }
    }
}
