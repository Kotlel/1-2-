using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    struct account
    {
        public int number;
        public string type;
        public int balance;
        public void Print()
        {
            Console.WriteLine($"Номер - {number}, Тип - {type}, Баланс - {balance}");
        }
        class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            BankAccountType cur = BankAccountType.Current;
            Console.WriteLine(cur);
        }
            enum BankAccountType
            {
                Current = 10,
                Savings = 12
            }
            // Task 2
            account acc1 = new account {number = 337, type = "Current", balance = 18000 };
            acc1.Print();
            // Task 3

            }
    }
}
