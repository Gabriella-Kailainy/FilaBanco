using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BancoFila2
{
    class Cliente
    {
        
            Cliente[] fila = new Cliente[10];
            public string nome;
            public int idade;
            public string rg;
            public string id;
            public bool prioritário;
            int quantCli = 0;
            int prioridades = 0;

            public Cliente(string nome = "", int idade = 0, string rg = "", string id = "", bool prioritario = false)
            {
                this.nome = nome;
                this.idade = idade;
                this.rg = rg;
                this.id = id;
                this.prioritário = prioritario;
            }

            public void CadastrarCliente()
            {
                if (quantCli >= 10)
                {
                    Console.WriteLine("A fila já está cheia. Não é possível cadastrar mais clientes.");
                }
                else
                {
                    Console.WriteLine("Digite o seu nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite a sua idade:");
                    int idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite seu Rg:");
                    string rg = Console.ReadLine();
                    Console.WriteLine("De um ID ao seu cliente:");
                    string id = Console.ReadLine();
                    Cliente c1 = new Cliente(nome, idade, rg, id);
                    fila[quantCli] = c1;
                    quantCli++;
                }
            }

            public void ListarFila()
            {
                if (quantCli == 0)
                {
                    Console.WriteLine("A fila está vazia.");
                }
                else
                {
                    Console.WriteLine("Fila de clientes:");
                    for (int i = 0; i < quantCli; i++)
                    {
                        if (fila[i] != null)
                        {
                            Console.WriteLine($"Cliente {i + 1}. {fila[i].nome}\n");
                        }
                    }
                }

            }
            public void IncluirClientePrioritario()
            {

                if (quantCli < 10)
                {

                    Console.WriteLine("Digite o seu nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite a sua idade:");
                    int idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite seu Rg:");
                    string rg = Console.ReadLine();
                    Console.WriteLine("De um ID ao seu cliente:");
                    string id = Console.ReadLine();
                    Cliente Pru = new Cliente(nome, idade, rg, id, true);

                    for (int i = quantCli - 1; i >= prioridades; i--)
                    {
                        fila[i + 1] = fila[i];
                    }
                    fila[prioridades] = Pru;
                    prioridades++;
                    quantCli++;
                }
                else
                {
                    Console.WriteLine("Fila Cheia:");
                }


            }
            public void AtenderCliente()
            {
                if (quantCli > 0)
                {

                    Cliente atendido = fila[0];

                    for (int i = 1; i < quantCli; i++)
                    {
                        fila[i - 1] = fila[i];
                    }
                    fila[quantCli - 1] = null;
                    quantCli--;
                    Console.Clear();
                    Console.WriteLine($"\nCliente Atendido:\nNome:{atendido.nome}\nRG:{atendido.rg}\nID:{atendido.id}\nPrioritario:{atendido.prioritário}\n");
                }
                else
                {
                    Console.WriteLine("Nao tem ninguem pra atender.");
                }

            }


        }
    }




