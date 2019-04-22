using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    class Pontuador
    {
        public int ObterPontuacaoDaRendaDaFamilia(double rendaTotal)
        {
            if (rendaTotal >= 1501.00 && rendaTotal <= 2000.00)
            {
                return 1;
            }

            return 0;
        }
    }
}
