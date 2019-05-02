using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
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
    }
}
