using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Work
    {
        public static string pathStart; // Путь к исходному файлу

        public void DialogWindows()
        {


            var ofd = new OpenFileDialog();
            ofd.Filter = "(text files)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathStart = ofd.FileName;
                var lin = File.ReadAllLines(pathStart);
                string[][] text = new string[lin.Length][];
                for (int i = 0; i < lin.Length; i++)
                {
                    text[i] = lin[i].Split(';');
                }
                string[,] a = new string[text.Length, text[text.Length - 1].Length];
                int j = 0;
                int k;
                string a1 = "pn10"; 

                foreach (string[] line in text) 
                {
                    k = 0;
                    foreach (string s in line)
                    {

                        a[j, k] = s;
                        Console.WriteLine(a[j, k]);
                        if ()
                        k++;
                    }
                    j++;
                }




            }
        }
    }
}
