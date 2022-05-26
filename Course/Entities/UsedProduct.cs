using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class UsedProduct : Product
    {
        public DateTime Manufacture { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price,DateTime manufacture)
            : base (name, price)
        {
            Manufacture = manufacture;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2")} (Manufactured date: {Manufacture.ToString("dd/MM/yyyy")}";

        }



    }
}
