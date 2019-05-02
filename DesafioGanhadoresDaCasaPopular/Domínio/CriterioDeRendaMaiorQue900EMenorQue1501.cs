using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    class CriterioDeRendaMaiorQue900EMenorQue1501 : ICriterioDePontuacao
    {
        public int ObterPontuacao(Familia familia)
        {
            if (familia.ObterRendaTotal() > 900 && familia.ObterRendaTotal() < 1501)
                return 3;

            return 0;
        }
    }
}
