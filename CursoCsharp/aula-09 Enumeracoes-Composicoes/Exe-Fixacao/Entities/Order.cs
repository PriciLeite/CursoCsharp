using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Exe_Fixacao.Entities;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Exe_Fixacao.Entities.Enums;

namespace CursoCsharp.aula_09_Enumeracoes_Composicoes.Exe_Fixacao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        //

        public Order() 
        {
        }
    
        public Order(DateTime date, OrderStatus status, Client client)
        {
            Moment = date;
            Status = status;
            Client = client;            
        }

        //

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    
        
        public void RemoveItem(OrderItem item) 
        {
            Items.Remove(item);
        }

        //

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)   
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yy"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Ordem Items: ");
            foreach (OrderItem item in Items) 
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total Price: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        
        
        }

    }

}







