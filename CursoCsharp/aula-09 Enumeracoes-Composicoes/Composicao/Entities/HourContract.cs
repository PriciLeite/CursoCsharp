

namespace CursoCsharp.aula_09_Enumeracoes_Composicoes.Composicao.Entities
{
    class HourContract
    {
        // Atributos e Propriedades:
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hours { get; set; }
    
        // Construtores:
        public HourContract() 
        {
        }
    
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
    

        // Método TotalValue:
        public double TotalValue()
        {
            return ValuePerHour * Hours; 
        }




    }

}
