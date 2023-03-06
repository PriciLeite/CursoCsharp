using System;
using System.Globalization;

namespace CursoCsharp.aula_15_Generics___Set___Dictionary.Generics.Ganeric_Exceptions_exe.resolvido.Entities
{
    class Stock : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Stock(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public override string ToString()
        {
            return Name
                   + "," 
                   + Price.ToString("F2", CultureInfo.InvariantCulture);
        }



        public int CompareTo(object? obj)
        {
            if (!(obj is Stock))
            {
                throw new ArgumentException("Argument is not an Stock!");
            }
            Stock other = obj as Stock;
            return Price.CompareTo(other.Price);

        } 

    }

}






