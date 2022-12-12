using Banking_System.Servises;
using System;

namespace Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new BankServise();

            var ShouldContinue = ""; 
            do
            {
                var userInput = ShowMenu();

                switch (userInput)
                {
                    case "1":
                        bank.CreateAccount();
                       
                        break;
                    case "2":
                        Console.WriteLine("View all accounts is in proces");
                        break;
                    case "3":
                        Console.WriteLine("View account is in proces");
                        break;
                    case "4":
                        bank.CreateTransaction();
                        break;
                    case "5":
                        Console.WriteLine("View all transaction is in proces");
                        break;
                    case "6":
                        var provisionRevenue = bank.TotalProvisionRevenue();
                        Console.WriteLine("Get provision revenue");
                        Console.WriteLine($"Total provision recenue is {provisionRevenue}");
                        break;
                    case "7":
                        var totalAmount = bank.TotalTransactionAmmount();
                        Console.WriteLine("Get all transactions");
                        Console.WriteLine($"Transaction transactions amount is {totalAmount}");
                        break;

                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine("Would you like to continue?Enter NO for exit");

                ShouldContinue = Console.ReadLine();

            } while (ShouldContinue != "no");
        }

        static string ShowMenu()
        {
            Console.WriteLine("Please choose one of the folowing options:");

            Console.WriteLine("1.Create new account");
            Console.WriteLine("2.View all accounts");
            Console.WriteLine("3.View account");
            Console.WriteLine("4.Create transaction");
            Console.WriteLine("5.View all transaction");
            Console.WriteLine("6.Get provision revenue");
            Console.WriteLine("7.Get all transaction amount");

            return Console.ReadLine().Trim();
        }

        
    }  
}
