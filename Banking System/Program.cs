using Banking_System.Models;
using System;

namespace Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();

            var ShouldContinue = "";
            do
            {
                var userInput = ShowMenu();

                switch (userInput)
                {
                    case "1":
                        var account = CreateAccount();
                        bank.AddAccount(account);
                        break;
                    case "2":
                        Console.WriteLine("View all accounts is in proces");
                        break;
                    case "3":
                        Console.WriteLine("View account is in proces");
                        break;
                    case "4":
                        Console.WriteLine("Create transaction is in proces");
                        break;
                    case "5":
                        Console.WriteLine("View all transaction is in proces");
                        break;
                    case "6":
                        Console.WriteLine("Get provision revenue is in proces");
                        break;
                    case "7":
                        Console.WriteLine("Get all transaction amount is in proces");
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

        static Account CreateAccount()
        {
            var newAccount =  new Account();
            Console.WriteLine("Please enter account number");
            newAccount.AccountNumber = Console.ReadLine();
            Console.WriteLine("Please enter you name");
            newAccount.Name = Console.ReadLine();
            Console.WriteLine("Please enter your surname");
            newAccount.Surname = Console.ReadLine();
            Console.WriteLine("Please enter your balance ");
            newAccount.InscreaseBalance(decimal.Parse(Console.ReadLine()));
            
            return newAccount;
        }
    }  
}
