using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    class BankAccount
    {

        private double balance;
        public BankAccount(double amount)
        {
            balance = amount;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public double GetBalance()
        {
            return balance;
        }
    }

}
