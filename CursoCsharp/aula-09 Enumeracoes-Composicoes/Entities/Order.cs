using System;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Entities.Enuns;

namespace CursoCsharp.aula_09_Enumeracoes_Composicoes.Entities
{
    class Order
    {
        public int Id { get; set; }

        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return "Id:" + Id 
                + " , " 
                + "Data: " + Moment
                + " , " 
                + "Status: " + Status; 
        }



    }
}
