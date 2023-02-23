

namespace CursoCsharp.aula_10_Heranca_Polimorfismo.Heranca.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
    
    
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
    
    
        public void UpdateBalance()
        {
            Balance = Balance * InterestRate;
        }

        //Método Sobrescrito da Super Classe Account para eliminar o desconto de $5.0:
        public override void Withdraw(double amount)
        {
            //Descontando o valor do Account + $2.0
            base.Withdraw(amount);
            Balance -= 2.0;
        }




    }


}
