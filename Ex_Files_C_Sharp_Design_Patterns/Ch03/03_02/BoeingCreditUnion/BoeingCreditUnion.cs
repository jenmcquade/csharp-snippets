using Interfaces;
using System;

namespace BoeingCreditUnion
{
    // Concrete ProductA1
    public class BoeingSavingsAccount : ISavingsAccount
    {
        public BoeingSavingsAccount()
        {
            Console.WriteLine("Returned BECU Savings Account");
        }
    }


    // Concrete ProductB1
    public class BoeingLoanAccount : ILoanAccount
    {
        public BoeingLoanAccount()
        {
            Console.WriteLine("Returned BECU Loan Account");
        }
    }


    // Concrete Factory 1
    public class BoeingCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            BoeingLoanAccount obj = new BoeingLoanAccount();
            return obj;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            BoeingSavingsAccount obj = new BoeingSavingsAccount();
            return obj;
        }
    }

}
