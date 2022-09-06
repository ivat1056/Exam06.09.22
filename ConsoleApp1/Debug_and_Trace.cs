using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Debug_and_Trace
    {
        /// <summary>
        /// Класс реализующий отладочные классы
        /// Позволяет выводить сообщения в отдельный файл 
        /// </summary>
        /// <param name="b"></param>
        public void DT1(double b)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("DebugTrace.txt")); //
            Debug.Indent();
            Trace.Indent();
            Debug.WriteLine("Debugged " + b);
            Trace.WriteLine("Traced " + b);
            Debug.WriteLine("");
            Trace.Flush();
        }

    }
}
