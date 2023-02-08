using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.Aula04.Classe.Atributos.Metodos.MetodosEstaticos
{
    internal class Exe01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os lados do triângulo X");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os lado do triângulo Y");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));
            
            double pY = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));


            Console.WriteLine("Área de X {0}", areaX.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine("Área de X {0}", areaY.ToString("F1", CultureInfo.InvariantCulture));

            if(areaY > areaY)
            {
                Console.WriteLine("Área X Maior!");
            }
            else
            {
                Console.WriteLine("Área Y Maior!");
            }
        
        
        }
    
    }

}
