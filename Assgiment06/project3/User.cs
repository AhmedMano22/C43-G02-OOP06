using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment06.project3
{
    abstract class User
    {
        public string? Name { get; set; }
        public abstract Discount GetDiscount();
    }


    #region classes inherit from  base class User
    // RegularUser: Applies a 5% PercentageDiscount
     class RegularUser : User
    {
        public RegularUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }

    // PremiumUser: Applies a $100 FlatDiscount
     class PremiumUser : User
    {
        public PremiumUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }

    // GuestUser: No discount is applied
     class GuestUser : User
    {
        public GuestUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return null; 
        }
    }
    #endregion


}
