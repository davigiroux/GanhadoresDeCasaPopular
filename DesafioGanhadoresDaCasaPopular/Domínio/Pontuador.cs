using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    class Pontuador
    {
        public IEnumerable<ICriterioDePontuacao> criterios;
        public int ObterPontuacaoGeral(Familia familia)
        {
            return criterios.Sum(criterio => criterio.ObterPontuacao(familia));
        }
    }

    internal interface ICriterioDePontuacao
    {
        int ObterPontuacao(Familia familia);
    }
}
