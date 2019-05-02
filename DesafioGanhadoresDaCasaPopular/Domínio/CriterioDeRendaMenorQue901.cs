using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    class CriterioDeRendaMenorQue901 : ICriterioDePontuacao
    {
        public int ObterPontuacao(Familia familia)
        {
            return familia.ObterRendaTotal() <= 900 ? 5 : 0;
        }
    }
}
