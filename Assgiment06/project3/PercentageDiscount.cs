using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment06.project3
{
    internal class PercentageDiscount : Discount
    {
        private readonly decimal Percentage;

        public PercentageDiscount(decimal percentage)
        {
            Name = "Percentage Discount";
            Percentage = percentage;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }
    }
}
