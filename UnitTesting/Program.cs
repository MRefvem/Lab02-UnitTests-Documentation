using System;

namespace UnitTesting
{
    public class Program
    {
        /// <summary>
        /// Variable to hold the current Balance of the account
        /// </summary>
        /// <param name="args"></param>
        static public decimal Balance = 5000;

        /// <summary>
        /// Main method - call the user interface method to activate the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            UserInterface();
        }

        /// <summary>
        /// Returns the value of the current balance
        /// </summary>
        /// <returns>decimal</returns>
        static public decimal ViewBalance()
        {

            Console.WriteLine($"Your current balance is ${Balance}.00");
            return Balance;
        }

        /// <summary>
        /// Subtracts money from the balance
        /// </summary>
        /// <returns>decimal</returns>
        static public decimal Withdraw(decimal withdrawalAmount)
        {

            if (withdrawalAmount > Balance)
            {
                Console.WriteLine("Insufficient funds");
                return Balance;
            }
            else if (withdrawalAmount < 0)
            {
                Console.WriteLine("Cannot withdraw amount less than $0.00.");
                return Balance;
            }
            else
            {
            Balance = Balance - withdrawalAmount;
                Console.WriteLine($"You withdrew ${withdrawalAmount}.00. Your new balance is ${Balance}.00.");
                return Balance;
            }

        }

        /// <summary>
        /// Adds money to the balance
        /// </summary>
        /// <returns>decimal</returns>
        static public decimal Deposit(decimal depositAmount)
        {

            if (depositAmount < 0)
            {
                Console.WriteLine("Cannot deposit a negative cash value.");
                return Balance;
            }
            else
            {
                Balance = Balance + depositAmount;
                Console.WriteLine($"You deposited ${depositAmount}.00. Your new balance is ${Balance}.00.");
                return Balance;
            }

        }

        /// <summary>
        /// User interface that prompts the user for standard ATM operations that links to each of the external methods
        /// </summary>
        public static void UserInterface()
        {

            bool running = true;

            while (running == true)
            {

                Console.WriteLine("Welcome to the ATM machine");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");

                string selection = Console.ReadLine();
                int userChoice = Convert.ToInt32(selection);

                if (userChoice == 1)
                {
                    ViewBalance();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("How much would you like to withdraw from your account?");

                    string withdrawalSelection = Console.ReadLine();
                    int withdrawalAmount = Convert.ToInt32(withdrawalSelection);

                    Withdraw(withdrawalAmount);

                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("How much would you like to deposit into your account?");

                    string depostSelection = Console.ReadLine();
                    int depositAmount = Convert.ToInt32(depostSelection);

                    Deposit(depositAmount);

                }
                else if (userChoice == 4)
                {

                    running = false;

                }
            }

            Console.WriteLine("The program has ended");
            return;

        }
    }
}
