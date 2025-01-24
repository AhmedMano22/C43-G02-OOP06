using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assgiment06.project3
{
    internal class FlatDiscount : Discount
    {
        private readonly decimal FlatAmount;

        public FlatDiscount(decimal flatAmount)
        {
            Name = "Flat Discount";
            FlatAmount = flatAmount;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity, 1);
        }
    }
}
