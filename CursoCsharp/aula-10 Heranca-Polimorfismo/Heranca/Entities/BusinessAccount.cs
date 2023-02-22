using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.aula_10_Heranca_Polimorfismo.Heranca.Entities
{
    class BusinessAccount : Account //Herança
    {
        public double LoanLimit { get; set; }

        
        public BusinessAccount()    
        {
        }
        
        public BusinessAccount(int number, string holder, double balance, double loanlimit) 
            : base(number,holder,balance)
        {
            LoanLimit = balance;
        }
    
    
        public void Loan(double amount)
        {
            if (amount < LoanLimit) 
            {
                Balance += amount;
            }
        }
    
    
    
    
    }
}
