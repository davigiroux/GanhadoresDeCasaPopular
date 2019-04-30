using System;
using System.Collections.Generic;
using System.Text;
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
            var pessoa = new Pessoa(TipoPessoa.Pretendente, new DateTime(1990, 02, 22), 1200.00);
            _familia.CadastrarPessoa(pessoa);

            var pessoaPretendenteDaFamilia = _familia.ObterPessoaPretendente();

            Assert.AreEqual(TipoPessoa.Pretendente, pessoaPretendenteDaFamilia.Tipo);
        }

        [Test]
        public void NaoDeveDeixarCadastrarOutroTipoDePessoaSeNaoHouverUmPretendenteCadastrado()
        {
            var pessoa = new Pessoa(TipoPessoa.Cônjugue, new DateTime(1990, 02, 22), 1200.00);

            Assert.Throws<Exception>(() => _familia.CadastrarPessoa(pessoa));
        }
    }
}
