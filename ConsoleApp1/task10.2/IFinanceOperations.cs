using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._2
{
    public interface IFinanceOperations
    {
       
        double CalculateLoanPercent(int month, double AmountperMonth);
        bool CheckUserHistory();
    }
}
