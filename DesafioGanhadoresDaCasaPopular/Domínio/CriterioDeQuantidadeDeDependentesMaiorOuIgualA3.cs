using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    public class CriterioDeQuantidadeDeDependentesMaiorOuIgualA3 : ICriterioDePontuacao
    {
        public int ObterPontuacao(Familia familia)
        {
            var quantidadeDeDependentes = familia.ObterQuantidadeDeDependentesComMenosDe19Anos();

            if (quantidadeDeDependentes >= 3)
                return 3;

            return 0;
        }
    }
}
