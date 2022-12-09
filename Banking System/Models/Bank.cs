using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System.Models
{
   public class Bank
    {
        public Bank()
        {
            Accounts = new Account[0];
            Transactions = new Transaction[0];
        }
        public Account[] Accounts { get; set; }
        public Transaction[] Transactions { get; set; }

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
        public void AddAccount(Account account)
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

    }
}
