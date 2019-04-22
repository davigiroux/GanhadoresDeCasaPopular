using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    class PontuadorTeste
    {

        [Test]
        public void DeveMarcar1PontoParaRendaTotalEntre1501E2000()
        {
            double pontuacaoEsperada = 1;
            var pontuador = new Pontuador();
            var pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(TipoPessoa.Pretendente, new DateTime(1996, 02, 24), 1800));
            var familia = new Familia(pessoas, StatusFamilia.ElegivelParaSelecao);

            var pontuacaoDaRenda = pontuador.ObterPontuacaoDaRendaDaFamilia(familia.ObterRendaTotal());

            Assert.AreEqual(pontuacaoEsperada, pontuacaoDaRenda);
        }


        [Test]
        public void DeveMarcar3PontosParaRendaTotalEntre901E1500()
        {
            double pontuacaoEsperada = 3;
            var pontuador = new Pontuador();
            var pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(TipoPessoa.Pretendente, new DateTime(1996, 02, 24), 1200));
            var familia = new Familia(pessoas, StatusFamilia.ElegivelParaSelecao);

            var pontuacaoDaRenda = pontuador.ObterPontuacaoDaRendaDaFamilia(familia.ObterRendaTotal());

            Assert.AreEqual(pontuacaoEsperada, pontuacaoDaRenda);
        }
    }
}
