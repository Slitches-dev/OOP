using System;
using System.Collections.Generic;
using System.Text;

namespace LR3
{
    abstract class Person
    {
        public abstract double InterestRate { get; }
        public abstract int CreditSize { get; } 

        public void Display()
        {
            Console.WriteLine($"Вам доступен кредит на сумму {CreditSize} с процентной ставкой {InterestRate} ");
        }
    }

    class Employee : Person
    {
        public override double InterestRate { get { return 0.05; } }
        public override int CreditSize { get { return 130000; } }
    }

    class Client : Person
    {
        public override double InterestRate { get { return 0.13; } }
        public override int CreditSize { get { return 80000; } }
    }

    class BadCreditHistoryClient : Person
    {
        public override double InterestRate { get { return 0.18; } }
        public override int CreditSize { get { return 30000; } }
    }

    class Beneficiary : Person
    {
        public override double InterestRate { get { return 0.1; } }
        public override int CreditSize { get { return 65000; } }
    }
}
