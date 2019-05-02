using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    class CriterioDeRendaMaiorQue900EMenorQue1501Teste
    {
        [Test]
        public void DeveRetornar3PontosParaRendaMaiorQue900EMenorQue1501()
        {
            var criterio = new CriterioDeRendaMaiorQue900EMenorQue1501();
            var familia = FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComRenda(901).Build()).Build();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(3, pontuacao);
        }
    }
}
