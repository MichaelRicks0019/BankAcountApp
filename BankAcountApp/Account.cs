using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcountApp
{
    class Account
    {
        private decimal accountBalance;

        public Account(decimal accountBalance)
        {
            AccountBalance = accountBalance;
        }

        public decimal AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                if (accountBalance < 0)
                {
                    throw new IndexOutOfRangeException ($"{nameof(accountBalance)} must be > than 0");
                }
                accountBalance = value;
            }

        }

        public virtual bool Credit (decimal credit)
        {
            if (credit < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(credit)} must be greater than 0");
            }
            AccountBalance += credit;
            return true;
        }

        public virtual bool Debit (decimal debit)
        {
            if (AccountBalance - debit < 0)
            {
                throw new Exception($"{nameof(debit)} Debit amount exceeded account balance" )
            }
            AccountBalance -= debit;
            return true;
        }
    }
}
