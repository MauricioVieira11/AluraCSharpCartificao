using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5;
            char resposta = 'S'; //System.Char

            byte nivelDeAzul = 0xFF; // = 255 decimal
            //nivelDeAzul = -3; //byte não tem número negativo

            short passageirosVoo = 230; //System.Int16
            passageirosVoo = -7; //short permite número negativo
            int populacao = 1500;
            populacao = -2300;
            long populacaoDoBrasil = 207_660_929; //+/- 207 milões
            
            sbyte nivelDeBrilho = -127;
            ushort passageirosNavio = 230; //u não tem sinal, não pode negativo
            uint estoque = 1500;
            ulong populacaoDoMundo = 7_000_000_000;

            Console.WriteLine($"Nível de Azul: {nivelDeAzul}");
            Console.WriteLine($"Passageitos Voo: {passageirosVoo}");
            Console.WriteLine($"População: {populacao}");
            Console.WriteLine($"população brasil: {populacaoDoBrasil}");

            Console.WriteLine($"Nivel Brilho: {nivelDeBrilho}");
            Console.WriteLine($"Passageiros navio: {passageirosNavio}");
            Console.WriteLine($"População do mundo: {populacaoDoMundo}");

            




        }
    }
}
