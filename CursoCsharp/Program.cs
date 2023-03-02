using System.IO;
using System;
using System.Globalization;
using System.Collections.Generic;
using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.AutoProperties;
using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.Encapsulamento;
using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.exe.conta.bancaria;
using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.Properties;
using CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.exe.fixação.vetores;
using CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.Params;
using CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.Referencia___Valor;
using CursoCsharp.Aula04.Classe.Atributos.Metodos.MetodosEstaticos;
using CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.Listas;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Composicao.Entities.Enums;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Composicao.Entities;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.stringBuilder.Entities;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Exe_Fixacao.Entities;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Exe_Fixacao.Entities.Enums;
using CursoCsharp.aula_10_Heranca_Polimorfismo.Heranca.Entities;
using CursoCsharp.aula_10_Heranca_Polimorfismo.exe.resolvido.Entities;
using CursoCsharp.aula_10_Heranca_Polimorfismo.exe.resolvido.Entities;
using CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.Entities;
using CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.Entities;
using Product = CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.Entities.Product;
using CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto;
using CursoCsharp.aula_10_Heranca_Polimorfismo.Metodos_Abstratos.Entities;
using CursoCsharp.aula_10_Heranca_Polimorfismo.Metodos_Abstratos.Entities.Enums;
using CursoCsharp.aula_10_Heranca_Polimorfismo.exe.proposto.final.Entities;
using CursoCsharp.aula_11_Tratamento_de_Excecoes.Entities;
using CursoCsharp.aula_11_Tratamento_de_Excecoes.Entities.Exceptions3;
using CursoCsharp.aula_13_Trabalhando_com_Arquivos.aula_195_File_FileInfo_IOEexception;
using CursoCsharp.aula_14_Interfaces.Exe.semInterface.Entities;
using CursoCsharp.aula_14_Interfaces.Exe.semInterface.Services;
using CursoCsharp.aula_14_Interfaces.exe.proposto.Entities;
using CursoCsharp.aula_14_Interfaces.exe.proposto.Services;

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





            /* Aula 60: Exercício de Fixação Modulo 05 Calsse Conta Bancária */
            #region
            /*
            ContaBancaria conta = new ContaBancaria("Sem Nome", 0000);

            
            // Criando as variáveis auxiliares para receber os valores digitados:
            Console.Write("Entre com núemero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito incial? (S/N)");
            char opcao = char.Parse(Console.ReadLine());


            // Criando o condicional if para decidir se haverá deposito inicial: 
            if(opcao == 's')
            {
                Console.Write("Digite o valor do deposito incial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nome, numero, depositoInicial);  // Atibuindo as variáveis auxiliares a classe primcipal. 
            }
            else
            {
                conta = new ContaBancaria(nome, numero);    //Segundo modelo de contrutor caso não exista deposito inicial;
            }

            // Imprimindo os dados da conta atualizados:
            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            // Chamando o Método Deposito:
            Console.WriteLine();
            Console.Write("Entre com valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            
            // Chamando o Método Saque:
            Console.WriteLine();
            Console.Write("Entre com valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
            */
            #endregion





            /* Aula 66: Tipos Referência e Tipos Valor */
            #region
            /* STACK */
            /* Point p;                         // Está sendo feito por Valor, logo ele só impreme valores se existir. 
             p.x = 20;                        // Instânciando sem new é obrigado atribuir valores para impressão.
             p.y = 30;                        // Aqui ele cria na Stack e imprime a própria Stack.
             Console.WriteLine(p); 

             */
            /* p = new Point();
             Console.Write("digite x: ");
             double valor1 = double.Parse(Console.ReadLine());           /* HEAP */
            /* Console.Write("digite y: ");                              // Aqui ele cria na Stack e aponta na heap, por isso está vazio (0, 0). 
             double valor2 = double.Parse(Console.ReadLine());           // Está sendo feito Referência, logo aparece os zeros por estar vazio.
             p.x = valor1;                                               // Intânciar usando new ele inicializa padrão (0 , 0).
             p.y = valor2;

             Console.WriteLine(p);
             */




            #endregion





            /* Aula 71: Exercício de Fixação Vetores: */
            #region
            /*
            AluguelQuartos[] vect = new AluguelQuartos[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Alugeul #" + i + ":");
                Console.Write("Nome: ");
                string name = Console.ReadLine();                

                Console.Write("Email: ");
                string email = Console.ReadLine();               

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new AluguelQuartos(name, email);
                Console.WriteLine();           
                          
            }

            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i].Name + "," + vect[i].Email);
                }
            }

            */

            #endregion





            /* Aula 72: Modificador de Parâmetros - PARAMS: */
            #region
            /*
            // Criando uma classe e fazendo a solução com VETOR:
            int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
            Console.WriteLine(result);



            // Criando a Classe e fazendo a Solução com modificador Params:
            int resulta = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(resulta);
            */
            #endregion





            /* Aula 76: LISTAS */
            #region
            /*
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Diana");
            list.Add("Barbara");
            list.Add("Debora");
            list.Add("Beatriz");
            list.Insert(1, "André");

            foreach (string obj in list)
                Console.WriteLine(obj);
            Console.WriteLine("Usando List Count: " + list.Count);

            Console.WriteLine("================================");

            // Primeira ocorrência de quem começa com 'D':
            string s1 = list.Find(x => x[0] == 'D');
            Console.WriteLine("First 'D': " + s1);

            // Última ocorrência de quem começa com 'M': 
            string s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Last 'M': " + s2);

            // Primeira posição de quem começa com a letra 'B':          
            int pos1 = list.FindIndex(x => x[0] == 'B');
            Console.WriteLine("Index posicion 'B': " + pos1);

            // Última posição de quem começa com a letra 'B':        
            int pos2 = list.FindLastIndex(x => x[0] == 'B');
            Console.WriteLine("Index posicion 'B': " + pos2);

            // Filtrando os caracteres com base no tamanho do obj:
            Console.WriteLine("===================================");

            Console.WriteLine("Filtrando os caracteres com base no tamanho do obj:");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remover elementos da lista:
            list.Remove("Debora");
            Console.WriteLine("======== Remove 'Debora' ================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj); 
            }

            list.RemoveAll(x => x[0] == 'B');
            Console.WriteLine("========== RemoveAll 'B'=================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj); 
            }

            list.RemoveAt(1);
            Console.WriteLine("======== RemoveAt (2) ====================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(1, 1);
            Console.WriteLine(" ======= Remove Range (1, 1) a partir do 1º -> 1 ====");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            */
            #endregion




            /* Aula 78: Exercício de fixação ->>> RESOLVENDO POR LISTAS AO INVÉS DE VETOR */
            #region
            /*
            Console.Write("Quantas pessoas serão cadastradas: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();   //Intamciação da lista


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionário #{i+1}:");
                
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));   //Adicionando à lista.

                Console.WriteLine("====================");
            }


            Console.Write("Digite Id para alterar salário: ");
            int id2 = int.Parse(Console.ReadLine());

            Employee s = list.Find(x => x.Id == id2);   //Verificando a ocorrência do id2 digitado.
            if (s != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                s.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id não existe!!! ");            
            }

            // Percorrendo a lista: 
            Console.WriteLine();
            foreach (Employee obj in list) 
            {
                Console.WriteLine(obj);
            }
           */
            #endregion




            /* Aula-79: Matrizes   */
            #region

            // Instânciando uma matriz:
            /*
            double[,] mat = new double[2, 3];

            // Altura da Matriz:
            Console.WriteLine(mat.Length);

            // Qte de linhas:
            Console.WriteLine(mat.Rank);

            // Dimensão da posição (0 - Coluna):
            Console.WriteLine(mat.GetLength(0));

            // Dimensão da posição (1 - Linha):
            Console.WriteLine(mat.GetLength(1));
            */
            #endregion




            // Aula-80 Exercício Resolvido Matriz :
            #region
            /*
            Console.Write("Tamanho da Matriz (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            // Percorrendo a matriz mat[i , j] e salvando os valores:

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);            
                }
                
            }

            //Encontrando a diágonal -> mat[i,i] pq a linha == coluna na diágonal:
            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write( mat[i,i] + "  ");
            }
            Console.WriteLine();


            // Contar quantos são os elementos negativos:
            int Count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Count++;
                    }
                }
            }
            Console.WriteLine("Negative Numbers: " + Count);
            */
            #endregion




            // Aula-81 Exercício de Fixação MAtriz:
            #region

            /*
            Console.WriteLine("========= Montando uma Matriz ===========");

            Console.Write("Digite número para linhas: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite número para Colunas: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================");

            Console.WriteLine("Digite os valores da matriz dando espaço entre os números: ");
            int[,] mat = new int[m, n];    // Matriz

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' '); //Recebe o valor como **String**

                for (int j = 0; j < n; j++)
                {
                    mat[i , j] = int.Parse(values[j]); // Transforma o valor em decimal e salva na coluna 'j'
                }
            }
            
            Console.WriteLine();
            Console.Write("Digite número para verificar: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("==============");
                        Console.WriteLine("Posição: " + i + "," + j + ":");


                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }

                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    
                    }
               
                }
           
           
            }
            */
            #endregion



            // Aula-124 Enumerações:
            #region
            /*
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PadingPayment
            };

            Console.WriteLine(order);

            // Converter o tipo Enumerado para String: **** 
            string txt = OrderStatus.PadingPayment.ToString();

            // Converte o tipo String para Enumerado: ****
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
            */


            #endregion





            // Aula-128 Exercicio Sobre -> Enumerações e Composição -> Diagrama da aula:
            #region
            /*
            Console.Write("Enter Departament's name: ");
            string departamento = Console.ReadLine();

            Console.WriteLine("Enter Work Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior / MidLevel / Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine()); //***** 

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // Instânciando as Classes:
            Departament dept = new Departament(departamento);
            Worker worker = new Worker(name, level, baseSalary, dept);



            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter contract #{i + 1} Data:");

                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());


                // Instânciando a Classe:
                HourContract contract = new HourContract(date, valuePerHour, hours);

                // Atribuindo o contrato que foi criado ao trabalhador:
                // Perceba que o trabalhador vai receber todos os contratos que forem digitados no for:
                worker.AddContract(contract);
            }
                Console.WriteLine();
                Console.Write("Enter month and year to calculete income (MM/YYYY): ");
                string monthAndyear = Console.ReadLine();                
                int month = int.Parse(monthAndyear.Substring(0, 2));
                int year = int.Parse(monthAndyear.Substring(3));

                Console.WriteLine("Name: " + worker.Name);
                Console.WriteLine("Departament: " + worker.Departament.Name);
                Console.WriteLine("Icome for: " + monthAndyear + ":" + "$" + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
                */

            #endregion





            // Aula-131 Exercicio Sobre -> Enumerações e Composição (demo StringBuilder):
            // OBS: Exercicio exemplificando a relação de Post -> Comentários. 
            #region
            /*
            Comment c1 = new Comment("Have a nice trip! ");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good nigth!");
            Comment c4 = new Comment("May the Force be with you!");

            Post p2 = new Post(
                DateTime.Now,
                "Good night guys",
                "See you Tomorrow",
                10);
            
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            */
            #endregion




            //Aula-134 Exercício de Fixação -> 
            #region
            /*
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());           

            Console.WriteLine("Enter Order Data: ");           
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            // Instanciação Cliente:
            Client client = new Client(name, email, date);

            // Instanciação Cliente Pedido:
            Order order = new Order(DateTime.Now, status, client);
            Console.WriteLine();
           

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Instanciação Produto:
                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //Instanciação Produto + quantidade:
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);

            }
            
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            */
            #endregion




            // CAP 10: HERANÇA E POLIMORFISMO - Aula-135 Herança 
            #region
            /*
            // Instânciar a classe BusinesAccount para verificar:
            //Balance { get; Protected set; }

            BusinessAccount account = new BusinessAccount(8001, "Priscila Leite", 1000, 5000);

            Console.WriteLine(account.Number);

            account.Balance = 500;   // ----> Neste caso o Protected não permite fazer alterações.
            */
            #endregion





            // Aula-136 ---> (continuação da aula 135...)
            #region
            /*
            // Intânciando um obj Account:
            Account acc = new Account(8010, "Alex", 0.0);

            // Intânciando um obj BusinessAccount:
            BusinessAccount bacc = new BusinessAccount(1818, "Maria", 0.0, 1000.0);

                           //OBS: BusinesAccount > é um < Account 


            //UPCASTING
            Account acc1 = bacc;  
            Console.WriteLine(acc1.Number + "  " + acc1.Holder + "  " + acc1.Balance);

            Account acc2 = new BusinessAccount(100, "Dora", 0.0, 1000.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.1);
            
            // Não consegue imprimir o LoanLimite pq ele não exite em Account!!!
            Console.WriteLine(acc2.Number + "  " + acc2.Holder + "  " + acc2.Balance);
            Console.WriteLine();



            //DOWNCASTING
            //BusinessAccount acc4 =  (BusinessAccount)acc2; //CASTING   OU -->>>
            BusinessAccount acc4 = acc3 as BusinessAccount;
            acc4.Loan(100.0);

           // BusinessAccount acc5 = (BusinessAccount)acc3;
           // ---> acc3 não BusinesAccount e o compilador não reconheceu o erro...

            if (acc3 is BusinessAccount)   //verificando...
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }
            */
            #endregion




            // Aula- 137 -> Sobreposição ou sobrescrita: "virtual" e "override"
            #region
            /*
            Account acc1 = new Account(1013, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1014, "Marta", 500.0, 0.1);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            */
            #endregion





            // Aula- 141 -> Exercício resolvido: 
            #region
            /*
            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsorced(y/n): ");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opcao =='y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }

                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                

            }
            
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list) 
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            */
            #endregion





            // Aula- 142 -> Exercício Propósto: 
            #region
            /*
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Product is: Common, use or imported (c / u / i) ?");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opcao == 'c')
                {
                    list.Add(new Product(name, price));
                }

                else if (opcao == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UseProduct(name, price, manufactureDate));
                }

                else 
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list) 
            {
                Console.WriteLine(product.Pricetag());
            }
            */
            #endregion



            // Aula- 144 -> Exercício Resolvido -> Classes Abstratas -> Métodos Abstratos:
            #region
            /*
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r / c) ?");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Color(Black/ Blue / Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                Console.Write("Width: ");
                

                if (opcao == 'r')
                {
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    list.Add(new Rectangle(width, height, color));
                }

                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }                
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
           foreach (Shape shape in list) 
           {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));

           }
           */
            #endregion




            // Aula- 146 -> Exercício Propósto -> Classes Abstratas -> Métodos  Abstratos:
            #region
            /*
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data: ");
                Console.Write("Individual or Company (i / c):");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opcao == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of Employess: ");
                    int numerOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numerOfEmployees));
                }

            }

            Console.WriteLine();
            
            double sum = 0.0;
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list) 
            {                
                double v = taxPayer.Tax();
                Console.WriteLine(taxPayer.Name + ":  $" + v.ToString("F2", CultureInfo.InvariantCulture));
                sum += v;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion





            // Aula- 152 -> Exercício Resolvido -> OBS: MODO GENÊRICO >>> PERSONALIZADO NA PRÓXIMA AULA...
            // Criando exceções personalizadas:
            #region
            /*
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-In date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/MM/yyyy):  ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            if (checkOut < checkIn)
            {
                Console.WriteLine("Erro: Data final menor do que Data inicial! ");
            }

            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                DateTime now = DateTime.Now;
                Console.WriteLine(now);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy):  ");
                checkOut = DateTime.Parse(Console.ReadLine());

                

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Erro in reservation: Reservation dates for update must be future dates!");
                }

                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Erro na data de reserva! ");
                }

                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }

            }
            */
            #endregion




            // Aula- 153 -> Exercício Resolvido -> OBS: MODO CORRETO COM (Try/Cath)
            #region
            /*
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

            */
            #endregion




            // Aula- 195 - File / FileInfo / IOEexception
            #region

            /*
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";


            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */
            #endregion






            // Aula 201- Exercício Proposto -> File / FileInfo / IOEexception
            #region
            /*
            Console.WriteLine("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        ProductSource prod = new ProductSource(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            */

            #endregion




            // Aula 206 - Exercício Resolvido: Implementando a Interface.
            #region
            /*
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
           

            Console.Write("Enter Price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per dau: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalServices rentalServices = new RentalServices(hour, day, new BrazilTaxServices()); //Intanciando com Interface.

            rentalServices.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.invoice);
            */
            #endregion


            // Aula 208 - Exercício de fixação
            #region
            /*
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }

            */
            #endregion

      
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }



    }



}































