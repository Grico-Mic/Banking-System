using Banking_System.Exceptions;
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
                try
                {
                    var userInput = ShowMenu();

                    switch (userInput)
                    {
                        case "1":
                            bank.CreateAccount();

                            break;
                        case "2":
                            bank.ViewAllAccounts();
                            break;
                        case "3":
                            bank.ViewAccount();
                            break;
                        case "4":
                            bank.CreateTransaction();
                            break;
                        case "5":
                            bank.ViewAllAccounts();
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
                }
                catch (BankingSystemExceptions ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                    Console.WriteLine("Please try again later");
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
