using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.AutoProperties;
using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.Encapsulamento;
using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.Properties;
using CursoCsharp.Aula04.Classe.Atributos.Metodos.MetodosEstaticos;
using System;
using System.Globalization;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* =========================================================================  */
            /* Aula-04 Classes-Atributos-Metodos-MembrosEstaticos */


            /*  Aplicação da Classe Triângulo  */
            #region
            /*  
            double xA, xB, xC, yA, yB, yC;
                       
            Console.WriteLine("Digite os lados do triângulo X");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             
            Console.WriteLine("Digite os lados do triângulo Y");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (xA+ xB + xC) / 2.0;
            double areaX = Math.Sqrt(pX *(pX - xA)*(pX - xB)*(pX - xC));

            double pY = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(pY *(pY - yA)*(pY - yB)*(pY - yC));

            Console.WriteLine("Área de X:{0}", areaX.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y:{0}", areaY.ToString("F1", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Área de X Maior!");
            }
            else
            {
                Console.WriteLine("Área de Y Maior!");
            }
            */
            #endregion





            /* >>>>>>>>> Usando a Classe Triângulo:  */
            #region
            /*Triangulo x, y;
              x = new Triangulo();            //Instânciando a Classe Triangulo;
              y = new Triangulo();            // Criando Obj e Atribuindo a Classe;
                                              // X e Y: São Object;
                                              // A B e C: São Atributos;


              Console.WriteLine("Digite os lados do triângulo X");
              x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

              Console.WriteLine("Digite os lados do triângulo Y");
              y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

              double areaX = x.Area();    //Usando o Método da Classe Triângulo;

              double areaY = y.Area();    //Usando o Método da Classe Triângulo;


              Console.WriteLine("Área de X:{0}", areaX.ToString("F1", CultureInfo.InvariantCulture));
              Console.WriteLine("Área de Y:{0}", areaY.ToString("F1", CultureInfo.InvariantCulture));

              if (areaX > areaY)
              {
                  Console.WriteLine("Área de X Maior!");
              }
              else
              {
                  Console.WriteLine("Área de Y Maior!");
              }
              */
            #endregion






            /* Aula 42:Classe Produto   */
            #region
            /*
            Produto p = new Produto();
            
            // Instanciando a Classe Produto:
            Console.WriteLine("Entre com dados do Produto: ");
            
            Console.Write("Nome do Produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Lendo dados:
            Console.WriteLine("Dados do Produto: " + p);


            // Implementando o Método Adicionar Produtos:
            Console.WriteLine("============================================");
            Console.Write("Digite a quantidade para adicionar ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados Atualizados: " + p);

            // Implementando o Método Remover Produtos:
            Console.WriteLine("============================================");
            Console.Write("Digite a quantidade para Remover do estoque: ");
            int qteRemove = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qteRemove);

            Console.WriteLine("Dados Atualizados: " + p);
            */
            #endregion






            /* Aula 46: Membros Estáticos • Versão 1: métodos na própria classe do programa */
            #region

            // Usando as funções dentro do programa principal;

            #endregion






            /* Aula 46: Membros Estáticos • Versão 2: Classe Calculadora com membros de INSTÂNCIA*/
            #region
            /*
            Calculadora calc = new Calculadora();

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio);


            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion






            /* Aula 46: Membros Estáticos • Versão 3: classe Calculadora com método estático */
            #region

            //Calculadora calc = new Calculadora(); >>>> ELIMINA ESSA INSTÂNCIAÇÃO DO OBJETO <<<
            // Chama a Classe pelo própio nome da Classe.
            /*

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);


            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion







            /* Aula 48: Exercício de fixação - Converso De Moeda */
            #region
            /*
            Console.Write("Digite -> Qual a Cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite -> Quantos dolares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.ConversaoDolarReal(cotacao, quantidade);

            Console.WriteLine("Valor a ser pago em Reais: $" + total.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion






            /* ====================================================================== */
            /* Aula-05 Construtores-Palavra this-Sobrecarga-Encapsulamento  */

            /* Aula 51: CONSTRUTORES Classe Produto */
            #region              
            /*
            // Instanciando a Classe Produto:
            Console.WriteLine("Entre com dados do Produto: ");
            
            Console.Write("Nome do Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Intânciando a Classe criando o produto:*************
            Produto p = new Produto(nome, preco, quantidade);


            // Lendo dados:
            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);


            // Implementando o Método Adicionar Produtos:
            Console.WriteLine("============================================");
            Console.Write("Digite a quantidade para adicionar ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados Atualizados: " + p);

            // Implementando o Método Remover Produtos:
            Console.WriteLine("============================================");
            Console.Write("Digite a quantidade para Remover do estoque: ");
            int qteRemove = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qteRemove);

            Console.WriteLine("Dados Atualizados: " + p);
            */
            #endregion







            /* Aula 52: SOBRECARGA Classe Produto */
            #region              
            /*
            // Instanciando a Classe Produto:
            Console.WriteLine("Entre com dados do Produto: ");

            Console.Write("Nome do Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



                        // Intânciando a Classe produto
            // ************* Construtor de 2 argumentos *************
            Produto p = new Produto(nome, preco);


            // Lendo dados:
            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);


            // Implementando o Método Adicionar Produtos:
            Console.WriteLine("============================================");
            Console.Write("Digite a quantidade para adicionar ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados Atualizados: " + p);

            // Implementando o Método Remover Produtos:
            Console.WriteLine("============================================");
            Console.Write("Digite a quantidade para Remover do estoque: ");
            int qteRemove = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qteRemove);

            Console.WriteLine("Dados Atualizados: " + p);
            */
            #endregion







            /* Aula 55: ENCAPSULAMENTO Classe Produto */
            #region
            /*
            Produto_01 p = new Produto_01("TV", 500.00, 2);

            Console.WriteLine(p.GetNome()); // Só exibe

            p.SetNome("TV 4k"); // Altera
            Console.WriteLine(p.GetNome()); // exibe novo nome


            Console.WriteLine(p.GetPreco()); // Só exibe

            Console.WriteLine(p.GetQuantidade());
            */
            #endregion





            /* Aula 56: PROPERTIES Classe Produto_02 */
            #region

            /*
           Produto_02 p = new Produto_02("TV", 500.00, 2);

            Console.WriteLine(p.Nome);          // Properties get {  } 
            p.Nome = "Tv 4k";                   // Properties set {  } 
            Console.WriteLine(p.Nome);          // Properties get {  }


            Console.WriteLine(p.Preco);         // Properties get {  }
            p.Preco = 200.00;                   // Properties set {  }
            Console.WriteLine(p.Preco);         // Properties get {  }


            Console.WriteLine(p.Quantidade);     // Properties get {  }   
            p.Quantidade = 5;                    // Properties set {  }
            Console.WriteLine(p.Quantidade);     // Properties get {  }   



            Console.WriteLine(p.ToString());      // Método ToString();  
            */
            #endregion






            /* Aula 57: AUTO PROPERTIES Classe Produto_03 */
            #region
            /*
            Produto_03 p = new Produto_03("Computador", 3000.00, 10);

            Console.WriteLine(p.Nome);          // Properties get {  } 
            p.Nome = "Notebook";                // Properties set {  } 
            Console.WriteLine(p.Nome);          // Properties get {  }


            Console.WriteLine(p.Preco);         // Properties get {  }
           // p.Preco = 200.00;                  =====>NÃO PERMITIDA PQ NA CLASSE ESTÁ PROPERTIES private set {  }
            Console.WriteLine(p.Preco);         // Properties get {  }


            Console.WriteLine(p.Quantidade);     // Properties get {  }   
           // p.Quantidade = 5;                   =====>NÃO PERMITIDA PQ NA CLASSE ESTÁ PROPERTIES private set {  }
            Console.WriteLine(p.Quantidade);     // Properties get {  }   



            Console.WriteLine(p.ToString());      // Método ToString();  
            */
            #endregion








        }


    }

}

