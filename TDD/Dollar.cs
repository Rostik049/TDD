using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    class Dollar
    {
        public int amount = 10;
        public Dollar(int amount) { this.amount = amount; }
        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public bool Equals(Object o)
        {
            Dollar dollar = (Dollar)o;
            return amount == dollar.amount;
        }
    }
}
