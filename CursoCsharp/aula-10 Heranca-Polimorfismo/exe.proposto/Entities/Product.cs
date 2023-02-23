

using System.Globalization;

namespace CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double  Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string Pricetag()
        {
            return Name + "  $" + Price.ToString("F2", CultureInfo.InvariantCulture); 
        }


    }
}
