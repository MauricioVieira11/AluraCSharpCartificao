using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");

            Console.WriteLine("Object com valor primitivo");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"mauObjeto: {meuObjeto}");

            Console.WriteLine($"meuObjeto.GetType(): {meuObjeto.GetType()}");
            Console.WriteLine($"");

            Console.WriteLine();
            Console.WriteLine("Object com referência de objeto");

            meuObjeto = new Jogador(); //classe joadror abaixo
            Jogador classRef;
            classRef = (Jogador)meuObjeto; //conversão explícita ou cast

            Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");


            

        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
