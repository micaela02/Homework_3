using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1
            double[] ex1 = { 1.1, 2.2, 3.3 };

            for (int i = 0; i < ex1.Count(); i++)
            {
                Console.WriteLine(ex1[i]);
            }

            //ex2
            int[] ex2 = { 12, 25, 79, 67, 73, 21, 56, 10, 96, 63 };
            int celMaiMicNumar = ex2.Min();
            int celMaiMareNumar = ex2.Max();
            Console.WriteLine("cel mai mare numar este: " + celMaiMareNumar.ToString() + " cel mai mic numar este: " + celMaiMicNumar.ToString());

            //ex2
            int[] ex3 = { 12, 25, 79, 67, 73, -21, 56, 10, 96, 63 };
            int numarNegativ = ex3.Min();
            Console.WriteLine("numarul negativ este: " + numarNegativ.ToString());

            //ex4

            string transforMe = "Aceasta este o tema";
            char[] x = new char[transforMe.Count()];

            for (int i = 0; i < transforMe.Count(); i++)
            {
                x[i] = transforMe.ElementAt(i);
                Console.WriteLine(x[i]);
            }

            //ex5
            char[] toUpperCase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            for (int i = 0; i < toUpperCase.Length; i++)
            {
                if (i % 2 == 0)
                {
                    string intermediar = toUpperCase[i].ToString().ToUpper();
                    toUpperCase[i] = intermediar.ElementAt(0);
                }

                Console.WriteLine(toUpperCase[i]);
            }
        }
    }
}
