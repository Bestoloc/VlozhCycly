using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace VlozhCycly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double O = 1;
            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            
            
            for (int i = 1; i <= n; i++)
            {
                double P = 0;

                for (int x = 1; x <= k; x++)
                {
                    P += Cos(2 * x * x + i);
                }

                O *= P;
            }
            Console.WriteLine($"{O:f5}");



        }
    }
}
