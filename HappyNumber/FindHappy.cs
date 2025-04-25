// Creator: Ryder Held
// Date: 4/25/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HappyNumber
{
    public class FindHappy
    {
        public bool HappyFinder(int n)
        {
            int check1 = SumOfSquares(n);
            int check2 = SumOfSquares(SumOfSquares(n));

            while (check1 != check2)
            {
                check1 = SumOfSquares(check1);
                check2 = SumOfSquares(SumOfSquares(check2));
            }

            return check1 == 1;
        }

        private int SumOfSquares(int n)
        {
            double sum = 0;
            while (n > 0)
            {
                sum += Math.Pow(n % 10, 2);
                n /= 10;
            }
            int x = Convert.ToInt32(sum);
            return x;
        }
    }
}
