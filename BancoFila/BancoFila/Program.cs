using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nome = new string[10];
            int[] Idade = new int[10];
            string[] Prioritário = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("1- Cadastrar o cliente.\n" +
                    "2- Inserir o cliente na lista.\n" +
                    "3- Listar a fila de clientes atuais.\n" +
                    "4- Incluir clientes prioritários.\n" +
                    "5- Digite q para sair do programa.");
                Console.ReadLine();

                Console.WriteLine("Digite o seu nome:");
                Console.ReadLine();
                Console.WriteLine("Digite a sua idade:");
                int.Parse(Console.ReadLine());
                Console.WriteLine("Você é um cliente prioritário? Sim/Não");
                Console.ReadLine();

                for (int p = 0; p < Nome.Length; p++)
                {
                    Console.WriteLine("Nome: ");
                    Nome[p] = Console.ReadLine();

                    Console.WriteLine("Idade: ");
                    Idade[p] = Convert.ToInt16(Console.ReadLine());


                    Console.ReadKey();
                }
            }
        }
    }
 }

