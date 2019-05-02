using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Domínio;
using DesafioGanhadoresDaCasaPopular.Testes;

namespace DesafioGanhadoresDaCasaPopular.Builder
{
    public class FamiliaBuilder
    {
        private List<Pessoa> _pessoas = new List<Pessoa>();
        private StatusFamilia _statusFamilia = StatusFamilia.ElegivelParaSelecao;

        public static FamiliaBuilder UmaFamilia()
        {
            return new FamiliaBuilder();
        }

        public Familia Build()
        {
            var familia = new Familia(_pessoas, _statusFamilia);
            return familia;
        }

        public FamiliaBuilder ComPessoa(Pessoa pessoa)
        {
            _pessoas.Add(pessoa);
            return this;
        }

        public FamiliaBuilder ComStatusFamilia(StatusFamilia statusFamilia)
        {
            _statusFamilia = statusFamilia;
            return this;
        }
    }
}
