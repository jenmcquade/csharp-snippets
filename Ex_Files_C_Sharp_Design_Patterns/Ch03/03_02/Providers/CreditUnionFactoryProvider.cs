using Interfaces;
using BoeingCreditUnion;
using NationalCreditUnion;
using CitiCreditUnion;

namespace Providers
{
    public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("CITI")) { return new CitiCreditUnionFactory(); }
            else
            if (accountNo.Contains("NATIONAL")) { return new NationalCreditUnionFactory(); }
            else
            if (accountNo.Contains("BECU")) { return new BoeingCreditUnionFactory(); }
            else
                return null;
        }
    }
}
