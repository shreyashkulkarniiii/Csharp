using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    using System;

    public class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a generic account.");
        }
    }
    public class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a savings account.");
        }
    }

    public class FixedDepositAccount : SavingsAccount
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine("Generic Account:");
            account.CalculateInterest();

            Console.WriteLine();

            SavingsAccount savingsAccount = new SavingsAccount();
            Console.WriteLine("Savings Account:");
            savingsAccount.CalculateInterest();

            Console.WriteLine();
            FixedDepositAccount fixedDepositAccount = new FixedDepositAccount();
            Console.WriteLine("Fixed Deposit Account:");
            fixedDepositAccount.CalculateInterest();
        }
    }
}
