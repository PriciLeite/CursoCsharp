using System;


namespace CursoCsharp.aula_14_Interfaces.Exe.semInterface.Services
{
    class BrazilTaxServices : ITaxService
    {

        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        
        }





    }
}
