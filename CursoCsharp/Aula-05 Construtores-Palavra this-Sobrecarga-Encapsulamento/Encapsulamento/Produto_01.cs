using System.Globalization;

namespace CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.Encapsulamento
{
    internal class Produto_01
    {
        // Atributos da Classe:
        private string _nome;
        private double _preco;
        private int _quantidade;
       
        
        // Construtor Padrão com todos os Atributos:     
        public Produto_01()
        {

        }


        // Construtor com parâmetros definidos:
        public Produto_01(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        // Método Get --> (Obter) valor armazenado:
        public string GetNome()
        {
            return _nome;
        }


        // Método Set --> (Definir) um novo valor para armazenar com restrição if:
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }


        // Método Get --> (Obter) valor de Preço armazenado:
        public double GetPreco()
        {
            return _preco;
        }


        // Método Get --> (Obter) quantidade armazenado:
        public int GetQuantidade()
        {
            return _quantidade;
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
