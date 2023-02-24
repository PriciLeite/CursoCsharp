using CursoCsharp.aula_10_Heranca_Polimorfismo.Metodos_Abstratos.Entities.Enums;


namespace CursoCsharp.aula_10_Heranca_Polimorfismo.Metodos_Abstratos.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }



        public Rectangle(double windth, double height, Color color) : base(color)
        { 
            Width = windth;
            Height = height;
        }

           
        
        public override double Area()
        {
            return Width * Height;
        }
    
    
    
    
    
    
    }
}
