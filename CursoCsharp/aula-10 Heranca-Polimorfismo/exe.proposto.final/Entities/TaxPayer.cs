

namespace CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.final.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }


        public TaxPayer() 
        {
        }

        public TaxPayer(string name, double anualIncome)
        { 
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();




    }
}
