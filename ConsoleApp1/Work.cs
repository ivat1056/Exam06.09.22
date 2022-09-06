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
    {/// <summary>
    /// В данном классе реализован весь функционал программы 
    /// </summary>
        public static string pathStart; // Путь к исходному файлу

        public void DialogWindows()
        {


            var ofd = new OpenFileDialog();
            ofd.Filter = "(text files)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MathModel f2 = new MathModel();
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
                int a1 = 700000;
                double p1 = 1;
                foreach (string[] line in text) 
                {
                    k = 0;
                    foreach (string s in line)
                    {

                        a[j, k] = s;
                        Console.WriteLine(a[j, k]);
                        double b1 = Convert.ToDouble(a[j, 0]); // сумма вклада 
                        double b2 = Convert.ToDouble(a[j, 1]); // процентная ставка 
                        double b3 = Convert.ToDouble(a[j, 2]); // срок ставки 
                        if (b1<a1)
                        {
                         if (b2==p1)
                            {
                                double summa = f2.MathM(b1, b2, b3);
                                Console.WriteLine("Сумма которую получит клиент по истечению срока ={0}", summa);
                            }
                         
                        }
                        k++;
                    }
                    j++;
                }




            }
        }
    }
}
