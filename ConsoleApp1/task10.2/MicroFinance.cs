using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._2
{
    public class MicroFinance : IFinanceOperations
    {

        public bool CheckUserHistory()
        {
            return true;
        }  
        public double CalculateLoanPercent(int month, double AmountperMonth)
        {
            const double yearlyPercentageIndex = 0.1;
            const int fixedCommision = 4;
            var totalLoan = month * AmountperMonth;
            double monthlyPercentage = yearlyPercentageIndex / 12;
            
            double totalPercent = 0;
            
            for (int i = 0; i < month; i++)
            {
                totalPercent += totalLoan * monthlyPercentage;
                totalLoan -=  AmountperMonth;
                
            }
            
            var sum = totalPercent + month * fixedCommision;
            return sum;


        }

        
    }
}
