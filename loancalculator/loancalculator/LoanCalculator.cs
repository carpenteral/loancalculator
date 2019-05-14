using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesse_demo
{
    public  class LoanCalculator
    {
        private double itsLoanAmount;
        private double itsRate;

        public  void    setLoanAmount( double amt )
        {
            itsLoanAmount = amt;
        }

        public  void    setFixedRate( double rate )
        {
            itsRate = rate;
        }

        void    execute()
        {

        }

        public  double  repaymentAmount()
        {
            LoanCalculatorImpl lc = new LoanCalculatorImpl(itsLoanAmount, itsRate);
            return lc.calculateRepaymentAmount();
        }
    }
}
