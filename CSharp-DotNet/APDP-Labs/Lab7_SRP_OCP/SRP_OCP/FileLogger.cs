using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Simulate logging to a file
            Console.WriteLine($"FileLogger: {message}");
        }
    }
}

