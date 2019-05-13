namespace ExercicioHeranca.Entities
{
    class ImportedProduct:Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() {}
        public ImportedProduct(string name,double price, double customsfee):base(name, price)
        {
            CustomsFee = customsfee;
        }

        public sealed override string PriceTag()
        {
            return base.PriceTag()+ $" (Custom fee: R${CustomsFee})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
