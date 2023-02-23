using CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.Entities;
using System.Globalization;

namespace CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto
{
    class ImportedProduct : Product 
    {
       public double CustomsFee { get; set; }

       public ImportedProduct()
       { 
       }

       public ImportedProduct(string name, double price, double customsFee) : base(name, price) 
        {
            CustomsFee= customsFee;
        }


        public double Pricetotal()
        {
            return base.Price + CustomsFee;
        }

        public override string Pricetag()
        {
            return Name + " $ " + Pricetotal().ToString("F2", CultureInfo.InvariantCulture) 
                + " (Customs fee: )" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }


    }

}
