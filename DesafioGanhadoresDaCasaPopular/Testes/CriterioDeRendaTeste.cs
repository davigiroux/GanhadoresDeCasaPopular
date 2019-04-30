using System;
using System.Collections.Generic;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    class CriterioDeRendaTeste
    {
        private Pontuador _pontuador;

        [SetUp]
        public void Setup()
        {
            _pontuador = new Pontuador(new List<ICriterioDePontuacao>() { new CriterioDeRenda() });
        }

        [Test]
        public void DeveRetornar5PontosParaRendasMenoresQue900()
        {
            var pessoa = new Pessoa(TipoPessoa.Pretendente, new DateTime(1996, 2, 24), 850.00);
            var familia = new Familia(new List<Pessoa>(){pessoa}, StatusFamilia.ElegivelParaSelecao);

            var pontuacao = _pontuador.ObterPontuacaoGeral(familia);

            Assert.AreEqual(5, pontuacao);
        }

        [Test]
        public void DeveRetornar3PontosParaRendasEntre901E1500()
        {
            var pessoa = new Pessoa(TipoPessoa.Pretendente, new DateTime(1996, 2, 24), 950.00);
            var familia = new Familia(new List<Pessoa>() { pessoa }, StatusFamilia.ElegivelParaSelecao);

            var pontuacao = _pontuador.ObterPontuacaoGeral(familia);

            Assert.AreEqual(3, pontuacao);
        }

        [Test]
        public void DeveRetornar1PontoParaRendasEntre1501E2000()
        {
            var pessoa = new Pessoa(TipoPessoa.Pretendente, new DateTime(1996, 2, 24), 1501.00);
            var familia = new Familia(new List<Pessoa>(){pessoa}, StatusFamilia.ElegivelParaSelecao);

            var pontuacao = _pontuador.ObterPontuacaoGeral(familia);

            Assert.AreEqual(1, pontuacao);
        }
    }
}
