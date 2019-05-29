using System;
using System.Collections.Generic;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using ExpectedObjects;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    class FamiliaTeste
    {
        private Familia _familia;

        [SetUp]
        public void Before()
        {
            var pessoas = new List<Pessoa>();
            _familia = new Familia(pessoas, StatusFamilia.ElegivelParaSelecao);
        }

        [Test]
        public void DeveCriarFamilia()
        {
            var pessoas = new List<Pessoa>()
            {
                PessoaBuilder.UmaPessoa().Build()
            };
            var familiaEsperada = new Familia(pessoas, StatusFamilia.ElegivelParaSelecao).ToExpectedObject();

            var familia = new Familia(pessoas, StatusFamilia.ElegivelParaSelecao);

            familiaEsperada.ShouldEqual(familia);
        }

        [Test]
        public void DeveConterUmaPessoaPretendente()
        {
            var pessoa = PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Pretendente).Build();
            _familia.CadastrarPessoa(pessoa);

            var pessoaPretendenteDaFamilia = _familia.ObterPessoaPretendente();

            Assert.AreEqual(TipoPessoa.Pretendente, pessoaPretendenteDaFamilia.Tipo);
        }

        [Test]
        public void NaoDeveDeixarCadastrarOutroTipoDePessoaSeNaoHouverUmPretendenteCadastrado()
        {
            var pessoa = PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Cônjugue).Build();

            Assert.Throws<Exception>(() => _familia.CadastrarPessoa(pessoa));
        }

        [Test]
        public void DeveContarQuantosDependentesComIdadeMenorQue19Anos()
        {
            var pessoas = new List<Pessoa>()
            {
                PessoaBuilder.UmaPessoa().Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).ComIdade(19).Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).ComIdade(18).Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).ComIdade(18).Build()
            };
            var familia = FamiliaBuilder.UmaFamilia().ComPessoas(pessoas).Build();

            var quantidadeDeDepententes = familia.ObterQuantidadeDeDependentesComMenosDe19Anos();

            Assert.AreEqual(2, quantidadeDeDepententes);
        }
    }
}
