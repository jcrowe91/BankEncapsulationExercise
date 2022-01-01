using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount checking = new BankAccount(0);
            Console.WriteLine($"How much would you like to deposit?");
            double userInput = Convert.ToDouble(Console.ReadLine());
            checking.Deposit(userInput);
            Console.WriteLine("Your new balance is...");
            Console.WriteLine(checking.GetBalance());
            Console.ReadLine();
        }



    }
}
