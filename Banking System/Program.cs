using System;

namespace Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var ShouldContinue = "";
            do
            {
                var userInput = ShowMenu();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Create new account is in proces");
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
    }
    }
}
