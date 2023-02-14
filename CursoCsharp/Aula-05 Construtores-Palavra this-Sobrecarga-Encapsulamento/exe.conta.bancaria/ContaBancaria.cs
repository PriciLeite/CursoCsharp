namespace CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.exe.conta.bancaria
{
    internal class ContaBancaria
    {
        // Atributos:

        public string Titular { get; set; }               //====>> Neste caso poderá ser alterado <<=======  

        public double Conta { get; private set; }          //====>> Neste caso não será permitido alterar set {  } <<=======

        public double Saldo { get; private set; }           //====>> Neste caso não será permitido alterar set {  } <<=======



        // Construtor com 2 Parâmetros:
        public ContaBancaria(string titular, double conta)
        {
            Titular = titular;
            Conta = conta;           
        }

        // Construtor com 3 Parâmetros:
        public ContaBancaria(string titular, double conta, double saldo) : this(titular, conta) 
        {
            Saldo= saldo;
        }





        // Propertie Deposito:
        public double Deposito
        {
            get { return Deposito; }

            set
            {
                if (value != 'f')
                {
                    if (value == 's')
                    {
                        Deposito = value;

                    }

                }
            }
               
        }


        public string Nome
        {
            get { return Titular; }

            set { Titular = value; }
        }


        












    }
}
