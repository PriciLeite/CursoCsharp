using System.Globalization;

namespace CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.Properties
{
    internal class Produto_02
    {
        // Atributos da Classe:
        private string _nome;
        private double _preco;
        private int _quantidade;


        // Construtor Padrão com todos os Atributos:     
        public Produto_02()
        {

        }


        // Construtor com parâmetros definidos:
        public Produto_02(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        // Criando a Properties e simplificando os métodos GetNome e SetNome:
        public string Nome
        {
            get{ return _nome; }   // Substitue GetNome().

            set                                         // Substitue SetNome().
            {
                if (value != null && value.Length > 1)  // Se era parâmetro que SetNome(string nome) nome vira value;
                {
                    _nome = value;
                }
            }
        
        }

        
        
        // Criando a Properties e simplificando os métodos GetPreco:
        public double Preco
        {
            get { return _preco; }    // Exibe (Obter)
            set { _preco = value; }   // Altera (Definir)
        }

        
        
        // Criando a Properties e simplificando os métodos GetQuantidade:
        public int Quantidade
        {
            get { return _quantidade; }     // Exibe (Obter)
            set { _quantidade = value; }    // Altera (Definir)
        }


        

        // Método Cálculo valor total estoque:
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        // Método adicionar produto sem que haja restrição if:
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        // Método remover produto sem que haja restrição if:
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }


        // Método ToString para Imprimir os valores: 
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
