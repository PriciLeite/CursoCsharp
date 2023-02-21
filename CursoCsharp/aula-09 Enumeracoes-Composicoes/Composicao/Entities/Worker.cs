using System;
using System.Collections.Generic;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Composicao.Entities.Enums;

namespace CursoCsharp.aula_09_Enumeracoes_Composicoes.Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        
        public WorkLevel Level { get; set; }
        
        public double BaseSalary { get; set; }
    
        public Departament Departament { get; set; }   //Composição com a Classe Departament
        
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //Composição com a Classe HourContract 


        public Worker()
        {
        }
    
        public Worker(string name, WorkLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament= departament;
        }
          
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
    
        public void RemoveContract(HourContract contract) 
        {
            Contracts.Remove(contract);
        }
        
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) 
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            
            }
            return sum;
        
        }   
    
    }
    
}

