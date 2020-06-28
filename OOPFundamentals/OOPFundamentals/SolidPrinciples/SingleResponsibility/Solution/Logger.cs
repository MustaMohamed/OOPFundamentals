using System;
using Solution.Core;

namespace Solution
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"Error: {message}");
        }
    }
}