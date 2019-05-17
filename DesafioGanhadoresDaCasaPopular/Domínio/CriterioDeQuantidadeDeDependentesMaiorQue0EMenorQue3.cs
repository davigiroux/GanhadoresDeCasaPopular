using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    public class CriterioDeQuantidadeDeDependentesMaiorQue0EMenorQue3 : ICriterioDePontuacao
    {
        public int ObterPontuacao(Familia familia)
        {
            if (familia.ObterQuantidadeDeDependentes() < 3 && familia.ObterQuantidadeDeDependentes() > 0)
                return 2;

            return 0;
        }
    }
}
