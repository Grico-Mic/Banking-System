using System;

namespace Banking_System.Models
{
    public class Transaction
    {
        public string AccountNumberFrom { get; set; }
        public string AccountNumberTo { get; set; }
        public decimal Amount { get; set; }
        public decimal Provision { get; set; }
        public DateTime EntryDate { get; set; }

        public void Print()
        {
            Console.WriteLine($"Account from: {AccountNumberFrom}");
            Console.WriteLine($"Account to: {AccountNumberTo}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Provision: {Provision}");
        }
    }
}
