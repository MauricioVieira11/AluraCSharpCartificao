using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            //string é um tipo de referÊncia
            string a = "bom dia";
            string b = "b";
            //adiciona ao conteúdo de "b";
            b = b + "om dia";
            Console.WriteLine($"a == b: {a==b}");
            Console.WriteLine($"(object)a == (object)b: {(object)a == (object)b}");

            string bomDia = "bom dia";
            Console.WriteLine($"bomDia[4]: {bomDia[4]}"); //acessa o 4º caractere 
            var caractere = bomDia[4];
            Console.WriteLine($"caractere.GetType(): {caractere.GetType()}");



        }
    }
}
