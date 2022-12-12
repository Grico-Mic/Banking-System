using System;
using Banking_System.Models;


namespace Banking_System.Servises
{
    public class BankServise
    {
        public BankServise()
        {
            Accounts = new Account[0];
            Transactions = new Transaction[0];
        }
        private Account[] Accounts { get; set; }
        private Transaction[] Transactions { get; set; }

         public decimal TotalProvisionRevenue()
        {
            var sum = 0.0m;
            foreach (var transactions in Transactions)
            {
                sum += transactions.Provision;
            }
            return sum;
        }
    
        
        public decimal TotalTransactionAmmount()
        {
            var sum = 0.0m;
            foreach (var transactions in Transactions)
            {
                sum += transactions.Amount;
            }
            return sum;
        }
        private void AddAccount(Account account)
        {
            // Accounts[0] = account;
            var newArray = new Account[Accounts.Length +1];
            for (int i = 0; i < Accounts.Length; i++)
            {
                newArray[i] = Accounts[i];
            }
            newArray[newArray.Length - 1] = account;
            Accounts = newArray;
        }
        public void CreateAccount()
        {
            var newAccount = new Account();
            Console.WriteLine("Please enter account number");
            newAccount.AccountNumber = Console.ReadLine();
            Console.WriteLine("Please enter you name");
            newAccount.Name = Console.ReadLine();
            Console.WriteLine("Please enter your surname");
            newAccount.Surname = Console.ReadLine();
            Console.WriteLine("Please enter your balance ");
            newAccount.InscreaseBalance(decimal.Parse(Console.ReadLine()));

            AddAccount(newAccount);
        }

    }
}
