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
        public void DeveMarcar3PontosParaRendaTotalEntre901E1500()
        {
            var pontuador = new Pontuador(new List<ICriterioDePontuacao>(){new CriterioDeRenda()});
            var pessoas = new List<Pessoa> {new Pessoa(TipoPessoa.Pretendente, new DateTime(1996, 02, 24), 1200)};
            var familia = new Familia(pessoas, StatusFamilia.ElegivelParaSelecao);

            var pontuacaoDaRenda = pontuador.ObterPontuacaoGeral(familia);

            Assert.AreEqual(3, pontuacaoDaRenda);
        }
    }
}
