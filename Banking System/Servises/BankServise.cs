using System;
using Banking_System.Models;
using System.Collections.Generic;

namespace Banking_System.Servises
{
    public class BankServise
    {
        public BankServise()
        {
            Accounts = new List<Account>();
            Transactions = new List<Transaction>();
        }
        private List<Account> Accounts { get; set; }
        private List<Transaction> Transactions { get; set; }

         public decimal TotalProvisionRevenue()
        {
            var sum = 0.0m;
            foreach (var transactions in Transactions)
            {
                sum += transactions.Provision;
            }
            return sum;
        }
        public void ViewAllAccounts()
        {
            foreach (var account in Accounts)
            {
                account.Print();
            }
        }

        public void ViewAllTransactions()
        {
            foreach (var account in Accounts)
            {
                account.Print();
            }
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
        //private void AddAccount(Account account)
        //{
        //    // Accounts[0] = account;
        //    var newArray = new Account[Accounts.Length +1];
        //    for (int i = 0; i < Accounts.Length; i++)
        //    {
        //        newArray[i] = Accounts[i];
        //    }
        //    newArray[newArray.Length - 1] = account;
        //    Accounts = newArray;
        //}
        public void CreateTransaction()
        {
            //get account from
            Console.WriteLine("Enter account number");
            var accountFromNumber = Console.ReadLine();
            var firsAccountNumber = GetAccounByNumber(accountFromNumber);
            //get account to
            Console.WriteLine("Enter account number");
            var accountToNumber = Console.ReadLine();
            var secondAccount = GetAccounByNumber(accountToNumber);
            //get ammount
            Console.WriteLine("Enter the ammount transfer");
            var transferAmount = decimal.Parse(Console.ReadLine());

            //decrease amount from first account
            var provision = transferAmount * 0.03m;
            firsAccountNumber.DecreaseBalance(transferAmount + provision);

            //inscrease amount to second account
            secondAccount.InscreaseBalance(transferAmount);

            var transaction = new Transaction();
            transaction.AccountNumberFrom = accountFromNumber;
            transaction.AccountNumberTo = accountToNumber;
            transaction.Amount = transferAmount;
            transaction.Provision = provision;
            transaction.EntryDate = DateTime.Now;

            AddTransaction(transaction);
        }

        private Account GetAccounByNumber( string accountNumber)
        {
           
            Account firstAccount = null;
            foreach (var account in Accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    firstAccount = account;
                    break;
                }
            }
            return firstAccount;
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

            Accounts.Add(newAccount);
        }

        private void AddTransaction(Transaction transaction)
        {

            Transactions.Add(transaction);

            //// Accounts[0] = account;
            //var newArray = new Transaction[Transactions.Length + 1];
            //for (int i = 0; i < Transactions.Length; i++)
            //{
            //    newArray[i] = Transactions[i];
            //}
            //newArray[newArray.Length - 1] = transaction;
            //Transactions= newArray;
        }
    }
}
