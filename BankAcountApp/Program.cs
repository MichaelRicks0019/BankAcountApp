using System;

namespace BankAcountApp
{
    class Program
    {
        static void Main(string[] args)
        {

            SavingsAccount JerrysAccount = new SavingsAccount(1000, .08m);
            CheckingAccount TomsAccount = new CheckingAccount(1000, .10m);
            Console.WriteLine(JerrysAccount);
            Console.WriteLine(TomsAccount);

            JerrysAccount.Credit(20);
            TomsAccount.Credit(20);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(JerrysAccount); 
            Console.WriteLine(TomsAccount);

            JerrysAccount.Debit(60);
            TomsAccount.Debit(60);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(JerrysAccount);
            Console.WriteLine(TomsAccount);

            JerrysAccount.Credit(-4);
            TomsAccount.Credit(-4);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(JerrysAccount);
            Console.WriteLine(TomsAccount);

            JerrysAccount.Debit(-4);
            TomsAccount.Debit(-4);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(JerrysAccount);
            Console.WriteLine(TomsAccount);


        }
    }
}
