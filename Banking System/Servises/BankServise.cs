using System;
using Banking_System.Models;
using System.Collections.Generic;
using System.Linq;

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
            return Transactions.Sum(x => x.Provision);

            //var sum = 0.0m;
            //foreach (var transactions in Transactions)
            //{
            //    sum += transactions.Provision;
            //}
            //return sum;
        }
        public void ViewAllAccounts()
        {
            Accounts.ForEach(x => x.Print());

            //foreach (var account in Accounts)
            //{
            //    account.Print();
            //}
        }

        public void ViewAccount()
        {
            Console.WriteLine("Please write your account");
            var accountNumber = Console.ReadLine();
            var account = GetAccounByNumber(accountNumber);
            //var accountTransactions = GetAccounByNumber(accountNumber);

            //if (account == null)
            //{
            //    Console.WriteLine("account does not exist");
            //    return;
            //}

            //account.Print();
            var accountTransactions = GetTransactionForAccount(accountNumber);


            accountTransactions.ForEach(x => x.Print());
        }

       

        public void ViewAllTransactions()
        {
            Transactions.ForEach(x => x.Print());
            //foreach (var account in Accounts)
            //{
            //    account.Print();
            //}
        }
    
        
        public decimal TotalTransactionAmmount()
        {
            return Transactions.Sum(x => x.Amount);
            //var sum = 0.0m;
            //foreach (var transactions in Transactions)
            //{
            //    sum += transactions.Amount;
            //}
            //return sum;
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

        public void CreateAccount()
        {
            Console.WriteLine("Please enter account number");
            var inputAccountNumber = Console.ReadLine();

            var account = GetAccounByNumber(inputAccountNumber);

            if(account == null)
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
            }else
            {
                Console.WriteLine($"Account with number {inputAccountNumber} already exist");
            }

            
        }

        private List<Transaction> GetTransactionForAccount(string accountNumber)
        {
            return Transactions
                .Where(x => x.AccountNumberFrom == accountNumber || x.AccountNumberTo == accountNumber)
                .ToList();
        }
        private Account GetAccounByNumber( string accountNumber)
        {
            return Accounts.FirstOrDefault(x => x.AccountNumber == accountNumber);

            //Account firstAccount = null;
            //foreach (var account in Accounts)
            //{
            //    if (account.AccountNumber == accountNumber)
            //    {
            //        firstAccount = account;
            //        break;
            //    }
            //}
            //return firstAccount;
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
