namespace CursoCsharp.Aula04.Classe.Atributos.Metodos.MetodosEstaticos
{
    internal class Calculadora
    {  
        // Atributo Pi Estático:
        public static double Pi = 3.14;  // Colocou static para chamar como método estático.


        
        // Método Cálculo da Circunferência:
        public static double Circuferencia(double r)
        {
            return 2.0 * Pi * r; 
        }

        
        
        // Método Cálcular Volume:
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r; //ao cubo.
        }


    }


}
