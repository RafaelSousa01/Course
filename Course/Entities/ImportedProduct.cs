

namespace Course.Entities
{
    class ImportedProduct : Product
    {

        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return CustomFee + Price;
        }


        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2")} (Customs fee: $ { CustomFee.ToString("F2")}";
        }



    }
}
