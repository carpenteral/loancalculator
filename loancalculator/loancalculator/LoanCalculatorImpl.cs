using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesse_demo
{
    public  class LoanCalculatorImpl
    {
        private double itsLoanAmount;
        private double itsRate;

        public  LoanCalculatorImpl( double amt, double rate )
        {
            itsLoanAmount = amt;
            itsRate = rate;
        }

        public  double  calculateRepaymentAmount()
        {
            return itsLoanAmount * (1 + itsRate / 100);
        }
    }
}
