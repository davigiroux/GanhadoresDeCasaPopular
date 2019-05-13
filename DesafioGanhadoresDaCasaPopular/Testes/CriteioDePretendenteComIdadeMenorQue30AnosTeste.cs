using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    public class CriteioDePretendenteComIdadeMenorQue30AnosTeste
    {

        [Test]
        public void DeveRetornar1PontoParaPretendenteComIdadeMenorQue30Anos()
        {
            var familia = FamiliaBuilder.UmaFamilia()
                .ComPessoa(PessoaBuilder.UmaPessoa().ComDataDeNascimento(DateTime.Now.AddYears(-29)).Build()).Build();
            var criterio = new CriteioDePretendenteComIdadeMenorQue30Anos();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(1, pontuacao);
        }

        [Test]
        public void NaoDevePontuarParaPretendenteComIdadeMaiorQue29Anos()
        {
            var familia = FamiliaBuilder.UmaFamilia()
                .ComPessoa(PessoaBuilder.UmaPessoa().ComDataDeNascimento(DateTime.Now.AddYears(-30)).Build()).Build();
            var criterio = new CriteioDePretendenteComIdadeMenorQue30Anos();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(0, pontuacao);
        }
    }
}
