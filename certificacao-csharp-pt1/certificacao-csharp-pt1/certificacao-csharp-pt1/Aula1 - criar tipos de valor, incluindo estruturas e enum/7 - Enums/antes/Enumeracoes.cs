using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            const int Seg = 0;
            const int Ter = 1;
            const int Qua = 2;

            DiasDaSemana primeiroDia = DiasDaSemana.Seg;

            DiasDetrabalho diasDetrabalho = DiasDetrabalho.Ter |DiasDetrabalho.Qui|DiasDetrabalho.Sex;

            Console.WriteLine(diasDetrabalho);

        }
    }

    enum DiasDaSemana : long { Seg = 3, Ter=10, Qua=15, Qui, Sex,Sab,Dom};
    enum DiasDetrabalho { Seg = 0,Ter=1,Qua=2,Qui=4,Sex=8,Sab=16,Dom=32 }
    


}
