using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Yuri", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}. ");

            try
            {
                account.MakeDeposit(658, DateTime.Now, "payment received");
                account.MakeWithdrawal(75, DateTime.Now, "Theatre");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Invalid Transaction");
                Console.WriteLine(e.ToString());
            }            
            var myTransactions = account.GetAccountHistory();
            Console.WriteLine(myTransactions);
            Console.WriteLine(account.Balance);
        }
    }   
}