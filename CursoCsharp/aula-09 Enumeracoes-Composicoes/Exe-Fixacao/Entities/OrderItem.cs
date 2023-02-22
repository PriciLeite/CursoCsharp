using System;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Exe_Fixacao.Entities;


namespace CursoCsharp.aula_09_Enumeracoes_Composicoes.Exe_Fixacao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
    
    
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return "Product: " + Product 
                + " ," 
                + "Price:" + Price 
                + ", " 
                + "Quantidy: " + Quantity;
        }

    }
    
    
}
    


