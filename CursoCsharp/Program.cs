﻿using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.AutoProperties;
using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.Encapsulamento;
using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.exe.conta.bancaria;
using CursoCsharp.Aula_05_Construtores_Palavra_this_Sobrecarga_Encapsulamento.Properties;
using CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.exe.fixação.vetores;
using CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.Params;
using CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.Referencia___Valor;
using CursoCsharp.Aula04.Classe.Atributos.Metodos.MetodosEstaticos;
using System;
using System.Globalization;
using System.Collections.Generic;
using CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.Listas;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Entities;
using CursoCsharp.aula_09_Enumeracoes_Composicoes.Entities.Enuns;

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











        }


    }


}




