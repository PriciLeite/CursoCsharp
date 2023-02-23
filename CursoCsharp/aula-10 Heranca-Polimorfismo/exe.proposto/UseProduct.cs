

using CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.Entities;
using System.Globalization;

namespace CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto
{
    class UseProduct : Product
    {
        public DateTime ManufactureDate { get; set; }


        public UseProduct() 
        {
        }

        public UseProduct(string name, double price, DateTime manufactureDate) 
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string Pricetag()
        {
            return Name + " (Used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date:  " + ManufactureDate.ToString("dd/MM/yyyy") + ")"; 
        }










    }
}





