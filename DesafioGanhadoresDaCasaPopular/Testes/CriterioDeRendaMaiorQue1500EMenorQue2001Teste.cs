using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    class CriterioDeRendaMaiorQue1500EMenorQue2001Teste
    {
        [Test]
        public void DeveRetornar1PontosParaRendaMaiorQue1500EMenorQue2001()
        {
            var criterio = new CriterioDeRendaMaiorQue1500EMenorQue2001();
            var familia = FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComRenda(1501).Build()).Build();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(1, pontuacao);
        }

        [Test]
        public void NaoDevePontuarSeRendaForMenorQue1500()
        {
            var criterio = new CriterioDeRendaMaiorQue1500EMenorQue2001();
            var familia = FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComRenda(1499).Build())
                .Build();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(0, pontuacao);
        }

        [Test]
        public void NaoDevePontuarSeRendaForMaiorQue2000()
        {
            var criterio = new CriterioDeRendaMaiorQue1500EMenorQue2001();
            var familia = FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComRenda(2001).Build())
                .Build();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(0, pontuacao);
        }
    }
}
