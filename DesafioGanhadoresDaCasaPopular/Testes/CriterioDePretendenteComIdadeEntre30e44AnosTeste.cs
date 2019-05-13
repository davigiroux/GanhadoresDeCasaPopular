using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    class CriterioDePretendenteComIdadeEntre30e44AnosTeste
    {

        [Test]
        public void DeveRetornar2PontosParaPretendenteComIdadeEntre30E44Anos()
        {
            var familia = FamiliaBuilder.UmaFamilia()
                .ComPessoa(PessoaBuilder.UmaPessoa().ComDataDeNascimento(DateTime.Now.AddYears(-44)).Build()).Build();
            var criterio = new CriterioDePretendenteComIdadeEntre30E44Anos();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(2, pontuacao);
        }

        [Test]
        public void NaoDevePontuarParaPretendenteComIdadeMenorQue30()
        {
            var familia = FamiliaBuilder.UmaFamilia()
                .ComPessoa(PessoaBuilder.UmaPessoa().ComDataDeNascimento(DateTime.Now.AddYears(-29)).Build()).Build();
            var criterio = new CriterioDePretendenteComIdadeEntre30E44Anos();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(0, pontuacao);
        }

        [Test]
        public void NaoDevePontuarParaPretendenteComIdadeMaiorQue44Anos()
        {
            var familia = FamiliaBuilder.UmaFamilia()
                .ComPessoa(PessoaBuilder.UmaPessoa().ComDataDeNascimento(DateTime.Now.AddYears(-45)).Build()).Build();
            var criterio = new CriterioDePretendenteComIdadeEntre30E44Anos();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(0, pontuacao);
        }
    }
}
