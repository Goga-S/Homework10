using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._2
{
    public class Bank : IFinanceOperations
    {
       
        public bool CheckUserHistory()
        {
            var random = new Random();
            var randNum = random.Next(1, 3);
            if (randNum == 1)
            {
                return false;
            }else
            {
                return true;
            }
        }
        public double CalculateLoanPercent(int month, double AmountperMonth)
        {
            double totalPercent;
            if (CheckUserHistory())
            {
                 totalPercent = month * AmountperMonth * 0.05;
            }else
            {
                throw new Exception("The loan is not available for the client");
            }

            return totalPercent;
        }

        
    }
}
