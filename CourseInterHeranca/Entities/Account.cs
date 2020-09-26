using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseInterHeranca.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string MyProperty { get; private set; }
        public double Balance { get; protected set; }


        public Account()
        {
        }
        public Account(int number, string myProperty, double balance)
        {
            Number = number;
            MyProperty = myProperty;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
