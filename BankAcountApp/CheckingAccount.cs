using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcountApp
{
    class CheckingAccount : Account
    {
        private decimal feePerTransaction;

        public CheckingAccount(decimal accountBalance, decimal feePerTransaction) 
            : base(accountBalance)
        {
            this.feePerTransaction = feePerTransaction;
        }

        public override bool Credit(decimal credit)
        {
           if (base.Credit(credit) == true)
            {
                base.AccountBalance -= feePerTransaction;
                return true;
            }
           else
            {
                return false;
            }
        }

        public override bool Debit(decimal debit)
        {
            if (base.Debit(debit) == true)
            {
                base.AccountBalance -= feePerTransaction;
                return true;
            }
            else
            {
                return false; ;
            }
        }
    }
}
