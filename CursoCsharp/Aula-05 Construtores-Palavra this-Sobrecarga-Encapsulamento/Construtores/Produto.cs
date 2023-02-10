using System.Globalization;

namespace CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.Construtores
{
    internal class Produto
    {
        // Atributos da Classe Produto:
        #region 

        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtor para instânciar o obejto com parâmetros:
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        #endregion




        //Método Valor Total da Quantidade em Estoque:
        #region
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        #endregion



        //Método adicionar produto no estoque:
        #region
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        #endregion



        //Método Remover produto no estoque:
        #region
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        #endregion



        // Método ToString para Leitura dos valores;
        #region
        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total:$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        #endregion

    }
}
