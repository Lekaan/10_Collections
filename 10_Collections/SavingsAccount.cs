using System;
using System.Globalization;

namespace _10_Collections
{
    internal class SavingsAccount : IAsset
    {
        public string Account { get; set; }
        public double InterestRate { get; set; }
        public double Value { get; set; }

        public SavingsAccount(string Account, int Value, double InterestRate)
        {
            this.Account = Account;
            this.Value = Value;
            this.InterestRate = InterestRate;
        }

        public override string ToString()
        {
            CultureInfo ci = new CultureInfo("en-us");
            string value = Value.ToString("F1", ci);
            string interestRate = InterestRate.ToString("F1").Replace(",", ".");

            return "SavingsAccount[value=" + value + ",interestRate=" + interestRate + "]";
        }

        public double GetValue()
        {
            return Value;
        }

        internal void ApplyInterest()
        {
            Value = Value*((InterestRate/100)+1);
        }

        public string GetName()
        {
            return Account;
        }
    }
}