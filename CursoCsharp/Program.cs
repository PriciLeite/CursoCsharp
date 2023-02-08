using CursoCsharp.Aula04.Classe.Atributos.Metodos.MetodosEstaticos;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Código sem aplicação da Classe Triângulo  
             * 
             *          double xA, xB, xC, yA, yB, yC;
             *          
            Console.WriteLine("Digite os lados do triângulo X");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             
            Console.WriteLine("Digite os lados do triângulo Y");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (xA+ xB + xC) / 2.0;
            double areaX = Math.Sqrt(pX *(pX - xA)*(pX - xB)*(pX - xC));

            double pY = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(pY *(pY - yA)*(pY - yB)*(pY - yC));

            Console.WriteLine("Área de X:{0}", areaX.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y:{0}", areaY.ToString("F1", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Área de X Maior!");
            }
            else
            {
                Console.WriteLine("Área de Y Maior!");
            }
            */
            
            /* >>>>>>>>> Usando a Classe Triângulo:  */
            
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os lados do triângulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os lados do triângulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));

            double pY = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

            Console.WriteLine("Área de X:{0}", areaX.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y:{0}", areaY.ToString("F1", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Área de X Maior!");
            }
            else
            {
                Console.WriteLine("Área de Y Maior!");
            }














        }




    }



}
