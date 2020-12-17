using System;
using atividade17_12.classe;

namespace atividade17_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();

            

            int escolha = 0;

           do
           {
               Console.WriteLine("MENU");
               Console.WriteLine("-----------------------------");
               Console.WriteLine("[0] - Cadastrar Produto");
               Console.WriteLine("[1] - Listar Produto");
               Console.WriteLine("[2] - Deletar Produto");
               Console.WriteLine("[3] - Alterar Produto");
               escolha = int.Parse(Console.ReadLine());

               switch (escolha)
               {
                    case 0:
                        Console.WriteLine("Digite o nome do produto: ");
                        produto.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o Valor do produto: ");
                        produto.Preco = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o código do produto");
                        produto.Codigo = int.Parse(Console.ReadLine());
                       
                       break;
                    case 1:
                        //Listar Produtos
                        for (var i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Produto {Nome[i]}");
                        }
                        
                       break;
                    case 2:
                        
                       break;
                    case 3:
                        
                       break;
                   default:
                       break;
               }
               
           } while (escolha != 0);
        }
    }
}
