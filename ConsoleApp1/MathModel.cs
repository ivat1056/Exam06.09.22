using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MathModel
    {
        /// <summary>
        /// Данный класс необходим для подсчета максимальной суммы которую получит клиент по истечению срока 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double MathM(double a, double b, double c)
        {
            double sum = Math.Pow((1 + (b / 100)), c);
            double sum2 = a * sum;
            return sum2; 
        }


    }
}
