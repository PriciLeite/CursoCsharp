﻿using System;
using CursoCsharp.aula_14_Interfaces.exe.proposto.Entities;
using System.Collections.Generic;

namespace CursoCsharp.aula_14_Interfaces.exe.proposto.Entities
{
    class Contract
    {

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
