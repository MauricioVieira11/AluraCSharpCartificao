using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f;

            //int massa = 6_000_000_000_000_000_000_000_000;
            //long massa = 6e24;
            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");

            float massaDaTerra = 5.9736e24f;
            Console.WriteLine($"Massa da Terra: {massaDaTerra}");

            float numeroPI = 3.14159f;
            Console.WriteLine($"Número Pi: {numeroPI}");

            double numeroMuitoMaior = 6e100;
            Console.WriteLine();
            Console.WriteLine("Operação com int, float, Short");

            int x = 3;
            short y = 5;
            float z = 4.5f;
            var resultado1 = (x * y)/z;
            Console.WriteLine("X*V = {0}:", resultado1);
            Console.WriteLine($"O resultado é do Tipo: {resultado1.GetType()}");


        }
    }
}
