using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    public class CriterioDePretendenteComIdadeMaiorQue44AnosTeste
    {

        [Test]
        public void DeveRetornar3PontosParaPretenteComIdadeMaiorQue44Anos()
        {
            var familia = FamiliaBuilder.UmaFamilia()
                .ComPessoa(PessoaBuilder.UmaPessoa().ComDataDeNascimento(DateTime.Now.AddYears(-45)).Build())
                .Build();
            var criterio = new CriterioDePretendenteComIdadeMaiorQue44Anos();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(3, pontuacao);
        }

        [Test]
        public void NaoDevePontuarParaPretendenteComIdadeMenorQue45Anos()
        {
            var familia = FamiliaBuilder.UmaFamilia()
                .ComPessoa(PessoaBuilder.UmaPessoa().ComDataDeNascimento(DateTime.Now.AddYears(-44)).Build())
                .Build();
            var criterio = new CriterioDePretendenteComIdadeMaiorQue44Anos();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(0, pontuacao);
        }
    }
}
