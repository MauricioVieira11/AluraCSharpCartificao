using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            int idade = 42;
            int copiaIdae = idade;
            Console.WriteLine($"Int idade = {idade}");
            Console.WriteLine($"int copiaIdade = {copiaIdae}");

            idade = 32;
            Console.WriteLine($"idade nova {idade}");
            Console.WriteLine($"copia Idade nova {copiaIdae}");
            Console.WriteLine("---------------------------");

            //Class Cliente
            var cliente1 = new Cliente("José da Silva", 42);
            var cliente2 = cliente1;

            Console.WriteLine($"Cliente1: {cliente1}");
            Console.WriteLine($"Cliente2: {cliente2}");

            cliente1.Nome = "Maria de Souza";
            Console.WriteLine($"Cliente1: {cliente1}");
            Console.WriteLine($"Cliente2: {cliente2}"); //alteração não afeta cliente2






        }
        class Cliente
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

            public Cliente(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }
           
            public override string ToString()
            {
                return $"Nome: {Nome}, Idade: {Idade}";
            }

        }
    }
}
