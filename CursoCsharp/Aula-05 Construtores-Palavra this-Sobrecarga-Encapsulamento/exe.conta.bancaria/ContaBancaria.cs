using System.Globalization;

namespace CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.exe.conta.bancaria
{
    internal class ContaBancaria
    {
        // Atributos:

        public string Titular { get; set; }               //====>> Neste caso poderá ser alterado <<=======  

        public int Conta { get; private set; }          //====>> Neste caso não será permitido alterar set {  } <<=======

        public double Saldo { get; private set; }           //====>> Neste caso não será permitido alterar set {  } <<=======



        // Construtor com 2 Parâmetros:
        public ContaBancaria(string titular, int conta)
        {
            Titular = titular;
            Conta = conta;           
        }

        // Construtor com 3 Parâmetros:
        public ContaBancaria(string titular, int conta, double saldo) : this(titular, conta) 
        {
            Saldo= saldo;
        }

        
        // Método Deposito: 
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        // Método Saque:
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0; 
        }
        
       
        
        // Método ToString:
        public override string ToString()
        {
            return "Conta: " + Conta 
                + " " + "Titular: " + Titular 
                + " " + "Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);            
            
        }



   
    }



}
