using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    public class CriterioDePretendenteComIdadeEntre30E44Anos : ICriterioDePontuacao
    {
        public int ObterPontuacao(Familia familia)
        {
            var dateTimeIdade = DateTime.Now - familia.ObterPessoaPretendente().DataDeNascimento;
            var idadeDoPretendente = dateTimeIdade.Days / 365;

            if (idadeDoPretendente >= 30 && idadeDoPretendente <= 44)
                return 2;

            return 0;
        }
    }
}
