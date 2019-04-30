using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    class CriterioDeRenda : ICriterioDePontuacao
    {
        public int ObterPontuacao(Familia familia)
        {
            if (familia.ObterRendaTotal() <= 900)
                return 5;
            else if (familia.ObterRendaTotal() >= 901 && familia.ObterRendaTotal() <= 1500)
                return 3;
            else if (familia.ObterRendaTotal() >= 1501 && familia.ObterRendaTotal() <= 2000)
                return 1;

            return 0;
        }
    }
}
