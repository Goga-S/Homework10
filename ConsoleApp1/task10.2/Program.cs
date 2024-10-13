using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new Bank();
            try
            {
                var sum = b.CalculateLoanPercent(12, 125);
                Console.WriteLine(sum);
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine(ex.Message);
                }

            }

            var m = new MicroFinance();
            var t = m.CalculateLoanPercent(10, 100);
            Console.WriteLine(t); 
        }
    }
}
