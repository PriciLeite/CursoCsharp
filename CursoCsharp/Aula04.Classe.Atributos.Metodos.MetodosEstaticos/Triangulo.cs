using System;
using System.Globalization;

namespace CursoCsharp.Aula04.Classe.Atributos.Metodos.MetodosEstaticos
{
    public class Triangulo
    {
        public double A ;
        public double B;        //Atributos-> Letra Maiúscula
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;           // Criando o Método de Cálculo da Área do Triângulo;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }


    }


}
