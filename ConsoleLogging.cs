using System;
using System.Collections.Generic;
using System.Text;

namespace MyBook
{
    internal class ConsoleLog
    {
        public void Log(string log)
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString() + ": " + log);
        }
    }
}
