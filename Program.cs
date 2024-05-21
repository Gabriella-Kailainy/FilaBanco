using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BancoFila2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "opcao";
            Cliente cliente = new Cliente();

            while (opcao.ToLower() != "q")
            {
                Console.WriteLine("1- Cadastrar o cliente.\n" +
                    "2- Listar a fila de clientes atuais.\n" +
                    "3- Incluir clientes prioritários.\n" +
                    "4- Atender Clientes.\n" +
                    "\nDigite q para sair do programa.");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        cliente.CadastrarCliente();
                        break;

                    case "2":
                        cliente.ListarFila();
                        break;

                    case "3":
                        cliente.IncluirClientePrioritario();
                        break;

                    case "4":
                        cliente.AtenderCliente();
                        break;

                    case "q":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

        }

    }

}
