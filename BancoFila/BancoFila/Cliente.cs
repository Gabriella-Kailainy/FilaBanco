using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFila
{
    class Cliente
    {
        public string Nome { get {return this.Nome;}}
        public int Idade { get { return this.Idade;}}
        public string Prioritário{ get { return this.Prioritário; }}



        public void MostrarDados(string nome, int Idade, string Prioritário)
        {
            Console.WriteLine(nome);
            Console.WriteLine(Idade);
            Console.WriteLine(Prioritário);
        }

    }
}
