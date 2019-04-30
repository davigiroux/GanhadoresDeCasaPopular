using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    public class Pontuador
    {
        private readonly IEnumerable<ICriterioDePontuacao> _criterios;

        public Pontuador(IEnumerable<ICriterioDePontuacao> criterios)
        {
            this._criterios = criterios;
        }

        public int ObterPontuacaoGeral(Familia familia)
        {
            return _criterios.Sum(criterio => criterio.ObterPontuacao(familia));
        }
    }
}
