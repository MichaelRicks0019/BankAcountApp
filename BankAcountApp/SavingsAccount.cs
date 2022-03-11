using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcountApp
{
    class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(decimal accountBalance, decimal interestRate) : base(accountBalance)
        {
            this.interestRate = interestRate;
        }

        public decimal CalculateInterese()
        {
            return base.AccountBalance * interestRate;
        }
    }
}
