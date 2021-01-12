using System;

namespace Lab02_unit_tests
{
    public static class Program
    {
        static public decimal balance = 1000;
        static void Main(string[] args)
        {
            StartSequence();
        }
        /// <summary>
        /// runs the menu interface for the console ATM
        /// </summary>
        public static void StartSequence()
        {

            int selection = 0;

            while (selection < 1 || selection > 4)
            {
                Console.WriteLine("Enter a number to select an action: \n1) View balance \n2) Make deposite \n3) Withdraw funds \n4) Exit");

                string input = Console.ReadLine();
                selection = Convert.ToInt32(input);
            }

            if (selection == 1)
            {
                Console.Clear();
                ViewBalance();
                StartSequence();
            }
            else if(selection == 2)
            {
                Console.Clear();
                Deposit();
                Console.Clear();
                StartSequence();
            }
            else if(selection == 3)
            {
                Console.Clear();
                Withdraw();
                StartSequence();
            }
            else if(selection == 4)
            {
                Console.WriteLine("Have a great day!");
            }
        }
        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your account balance is: {balance}");
            return balance;
        }

        public static decimal Withdraw()
        {
            Console.WriteLine($"Enter the amount you would like to withdraw");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            if(balance - input > 0 && input > 0)
            {
                balance = balance - input;
            }
            else
            {
                Console.WriteLine("Oops, looks like you balance is bone dry!");
            }
            return balance;
        }

        public static decimal Deposit()
        {
            Console.WriteLine("Please enter the amount you would like to deposit");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            if(input > 0)
            {
                balance = balance + input;
            }
            return balance;
        }
    }
}
