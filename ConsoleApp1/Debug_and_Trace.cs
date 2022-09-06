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
        public void DT1(double b)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("DebugTrace.txt"));
            Debug.Indent();
            Trace.Indent();
            Debug.WriteLine("Debugged " + b);
            Trace.WriteLine("Traced " + b);
            Debug.WriteLine("");
            Trace.Flush();
        }

    }
}
