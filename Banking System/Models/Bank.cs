using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System.Models
{
   public class Bank
    {
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

    }
}
