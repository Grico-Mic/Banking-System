using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System.Models
{
   public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private decimal Balance { get; set; }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void InscreaseBalance(decimal amount)
        {
            if (amount > 0)
            {

              Balance += amount;
            }
        }

        public void DecreaseBalance(decimal amount)
        {
            if (amount > 0 && amount < Balance)
            {

                Balance -= amount;
            }
        }
    }
}
