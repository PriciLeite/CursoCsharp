using System.Globalization;

namespace CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.AutoProperties
{
    internal class Produto_03
    {
        // Atributos da Classe:  ========>>> Será feito no próprio atributo a Properties AUTO IMPLEMENTADAS
        // já que ela não tem clausula if <<=====
       
        
        private string _nome;                          //====>> Nome não pode pq tem clausula if no set{ } <<=======

        public double Preco { get; private set; }      //====>> Neste caso não será permitido o set {  } <<=======
        
        public int Quantidade { get; private set; }     //====>> Neste caso não será permitido o set {  } <<=======


        // Construtor Padrão com todos os Atributos:     
        public Produto_03()
        {

        }


        // Construtor com parâmetros definidos:
        public Produto_03(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        // Criando a Properties e simplificando os métodos GetNome e SetNome:
        // =====>>>  PRÓPRIEDADES CUSTOMIZADAS <<<=======
        public string Nome
        {
            get { return _nome; }                       // Substitue GetNome().

            set                                         // Substitue SetNome().
            {
                if (value != null && value.Length > 1)  // Se era parâmetro que SetNome(string nome) nome vira value;
                {
                    _nome = value;
                }
            }

        }
                


        // Método Cálculo valor total estoque:
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }




        // Método adicionar produto sem que haja restrição if:
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }




        // Método remover produto sem que haja restrição if:
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }




        // Método ToString para Imprimir os valores: 
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }




   
    
    }





}
