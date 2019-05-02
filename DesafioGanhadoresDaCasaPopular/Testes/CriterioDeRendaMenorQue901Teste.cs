using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    class CriterioDeRendaMenorQue901Teste
    {

        [Test]
        public void DeveRetornar5PontosParaRendaMenorOuIgualA900()
        {
            var criterio = new CriterioDeRendaMenorQue901();
            var familia = FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComRenda(850.00).Build())
                .Build();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(5, pontuacao);
        }

        [Test]
        public void NaoDevePontuarSeRendaForMaiorQue900()
        {
            var criterio = new CriterioDeRendaMenorQue901();
            var familia = FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComRenda(901).Build())
                .Build();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(0, pontuacao);
        }
    }
}
