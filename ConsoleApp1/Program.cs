using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApp1
{
    /// <summary>
    /// Данная программа предназначена  для расчета 
    /// В первый столбик записывается сумма, которую клиент вложил в банк
    /// Во второй столбик записывается процентная ставка по вкладом
    /// </summary>
    internal class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Work class1 = new Work(); 
            class1.DialogWindows();
        }
    }
}
