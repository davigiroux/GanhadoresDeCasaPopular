using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    public class CriteioDePretendenteComIdadeMenorQue30Anos : ICriterioDePontuacao
    {
        public int ObterPontuacao(Familia familia)
        {
            var dateTimeIdade = DateTime.Now - familia.ObterPessoaPretendente().DataDeNascimento;
            var idadeDoPretendente = dateTimeIdade.Days / 365;

            if (idadeDoPretendente < 30)
                return 1;

            return 0;
        }
    }
}
