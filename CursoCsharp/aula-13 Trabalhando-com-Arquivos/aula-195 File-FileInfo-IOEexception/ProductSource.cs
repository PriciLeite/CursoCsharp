using System;

namespace CursoCsharp.aula_13_Trabalhando_com_Arquivos.aula_195_File_FileInfo_IOEexception
{
    class ProductSource
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    
        
        public ProductSource(string name, double price, int quantity) 
        {
            Name = name;
            Price = price;
            Quantity = quantity;        
        }

        public double Total()
        { 
            return Price * Quantity;            
        }
    
    
    }
}
