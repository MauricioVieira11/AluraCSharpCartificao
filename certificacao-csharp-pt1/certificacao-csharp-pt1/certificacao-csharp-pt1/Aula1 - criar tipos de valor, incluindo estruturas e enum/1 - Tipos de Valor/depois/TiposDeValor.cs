using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 30;
            Console.WriteLine(idade);

            //int = System.int32
            int copiaIdade = idade;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"Copia idade: {copiaIdade}");

            idade = 23;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"Copia idade: {copiaIdade}");

            //? == System.Nullable
            //pode colocar valores nulos 
            int? idade2 = null;
            System.Nullable<int> idade3 = null;
        }
    }
}
