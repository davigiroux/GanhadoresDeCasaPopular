using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    class CriterioDePretendenteComIdadeMaiorQue44Anos : ICriterioDePontuacao
    {
        public int ObterPontuacao(Familia familia)
        {
            var dateTimeIdade = DateTime.Now - familia.ObterPessoaPretendente().DataDeNascimento;

            if (dateTimeIdade.Days / 365 > 44)
                return 3;

            return 0;
        }
    }
}
