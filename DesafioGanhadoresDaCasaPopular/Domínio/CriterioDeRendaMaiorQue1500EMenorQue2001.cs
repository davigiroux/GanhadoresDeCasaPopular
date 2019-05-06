using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    class CriterioDeRendaMaiorQue1500EMenorQue2001 : ICriterioDePontuacao
    {
        public int ObterPontuacao(Familia familia)
        {
            if (familia.ObterRendaTotal() > 1500 && familia.ObterRendaTotal() < 2001)
                return 1;

            return 0;
        }
    }
}
