using System;
namespace ExercicioHeranca.Entities
{
    class UsedProduct:Product
    {
        DateTime ManufactureDate;

        public UsedProduct() {}
        public UsedProduct(string name,double price, DateTime date):base(name, price)
        {
            ManufactureDate = date;
        }

        public sealed override string PriceTag()
        {
            return $"{Name} (used) R${Price} (Manufacture date: {ManufactureDate.ToString("DD/MM/YYYY")})";
        }
    }
}
