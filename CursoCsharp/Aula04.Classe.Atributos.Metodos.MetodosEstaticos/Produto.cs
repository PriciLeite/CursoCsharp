using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.Aula04.Classe.Atributos.Metodos.MetodosEstaticos
{
    internal class Produto
    {
        // Atributos da Classe Produto:
        #region 
        public string Nome;
        public double Preco;
        public int Quantidade;
        #endregion




        //Método Valor Total da Quantidade em Estoque:
        #region
        public double ValorTotalEmEstoque()
        {
            return  Quantidade *  Preco;             
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
                + Preco.ToString("F2", CultureInfo. InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total:$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        #endregion


        // 
    
    
    
    
    
    }




}
