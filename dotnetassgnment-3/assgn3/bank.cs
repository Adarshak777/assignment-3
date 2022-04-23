using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgn3
{
    internal class bank
    {
        double rate;

        public void loanCalculator(double loanamount)
        {
            Console.WriteLine(" Enter a loanamount");
            loanamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate of interest");
            rate = Convert.ToDouble(Console.ReadLine());
            double interest = (loanamount * rate) / 100;
            Console.WriteLine("Rate of interest for " + rate + "%  is : " + interest);

        }

    }
}
