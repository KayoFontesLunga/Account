using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class SpecialAccount : CurrentAccount
    {
        private double limit = 900;

        public double Limit { get => limit; set => limit = value; }

        public void CheckLimit()
        {
            Console.WriteLine("The current limit is {0}", Limit);
        }

        public double DecreaseLimit(double amount)
        {
            double newLimit = limit - amount;
            return newLimit;
        }

        public double IncreaseLimit(double amount)
        {
            double newLimit = limit + amount;
            return newLimit;
        }
    }
}
