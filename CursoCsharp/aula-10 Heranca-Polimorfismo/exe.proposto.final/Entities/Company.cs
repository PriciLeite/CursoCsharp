﻿using CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.final.Entities;

namespace CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.final.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }


        public Company()
        { 
        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }



    }
}
