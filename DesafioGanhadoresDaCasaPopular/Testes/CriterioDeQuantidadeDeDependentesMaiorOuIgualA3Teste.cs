using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    public class CriterioDeQuantidadeDeDependentesMaiorOuIgualA3Teste
    {
        [Test]
        public void DeveRetornar3PontosParaQuantidadeDeDependentesMaiorOuIgualA3()
        {
            var pessoas = new List<Pessoa>()
            {
                PessoaBuilder.UmaPessoa().Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).Build()
            };
            var familia = FamiliaBuilder.UmaFamilia().ComPessoas(pessoas).Build();
            var criterio = new CriterioDeQuantidadeDeDependentesMaiorOuIgualA3();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(3, pontuacao);
        }

        [Test]
        public void NaoDevePontuarParaQuantidadeDeDependentesMenorQue3()
        {
            var pessoas = new List<Pessoa>()
            {
                PessoaBuilder.UmaPessoa().Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).Build()
            };
            var familia = FamiliaBuilder.UmaFamilia().ComPessoas(pessoas).Build();
            var criterio = new CriterioDeQuantidadeDeDependentesMaiorOuIgualA3();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(0, pontuacao);
        }

        [Test]
        public void NaoDeveConsiderarDependentesComIdadeMaiorQue18Anos()
        {
            var pessoas = new List<Pessoa>()
            {
                PessoaBuilder.UmaPessoa().Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).ComIdade(25).Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).ComIdade(10).Build(),
                PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Dependente).ComIdade(18).Build()
            };
            var familia = FamiliaBuilder.UmaFamilia().ComPessoas(pessoas).Build();
            var criterio = new CriterioDeQuantidadeDeDependentesMaiorOuIgualA3();

            var pontuacao = criterio.ObterPontuacao(familia);

            Assert.AreEqual(0, pontuacao);
        }
    }
}
