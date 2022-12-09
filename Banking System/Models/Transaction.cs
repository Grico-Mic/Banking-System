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
    }
}
