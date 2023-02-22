using System;


namespace CursoCsharp.aula_09_Enumeracoes_Composicoes.Exe_Fixacao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    
        public Product()
        {   
        }

        public Product(string productName, double price)
        {
            Name = productName;
            Price = price;
        }
    }
}
