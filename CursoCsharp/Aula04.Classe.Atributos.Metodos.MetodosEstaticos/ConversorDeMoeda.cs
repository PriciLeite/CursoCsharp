namespace CursoCsharp.Aula04.Classe.Atributos.Metodos.MetodosEstaticos
{
    internal class ConversorDeMoeda
    {
        // Atributo da classe estático:
        public static double IOF = 6.0;


        // Método Valor a ser pago em $:
        public static double ConversaoDolarReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF / 100.0;

        }

    }

}
