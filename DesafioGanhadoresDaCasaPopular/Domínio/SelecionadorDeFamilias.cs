using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    public class SelecionadorDeFamilias
    {
        private Pontuador _pontuador;

        public SelecionadorDeFamilias(Pontuador pontuador)
        {
            _pontuador = pontuador;
        }

        public List<Familia> ObterFamiliasSelecionadas(List<Familia> familiasQueSeCandidataram)
        {
            var familiasSelecionadas = new List<Familia>();
            foreach (var familia in familiasQueSeCandidataram)
            {
                if (FamiliaPodeSerSelecionada(familia))
                   familiasSelecionadas.Add(familia);
            }

            return familiasSelecionadas;
        }

        private bool FamiliaPodeSerSelecionada(Familia familia)
        {
            return familia.Status == StatusFamilia.ElegivelParaSelecao && _pontuador.ObterPontuacaoGeral(familia) > 0;
        }
    }
}
