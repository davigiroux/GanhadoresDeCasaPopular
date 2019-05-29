using System.Collections.Generic;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    class PontuadorTeste
    {
        private Pontuador _pontuador;

        [SetUp]
        public void Setup()
        {
            var criterios = new List<ICriterioDePontuacao>()
            {
                new CriterioDeRendaMenorQue901(),
                new CriterioDeRendaMaiorQue900EMenorQue1501(),
                new CriterioDeRendaMaiorQue1500EMenorQue2001(),
                new CriterioDePretendenteComIdadeMaiorQue44Anos(),
                new CriterioDePretendenteComIdadeEntre30E44Anos(),
                new CriteioDePretendenteComIdadeMenorQue30Anos(),
                new CriterioDeQuantidadeDeDependentesMaiorOuIgualA3(),
                new CriterioDeQuantidadeDeDependentesMaiorQue0EMenorQue3()
            };
            _pontuador = new Pontuador(criterios);
        }

        [Test]
        public void DeveSomarPontuacaoDeDoisCriteriosAtendidos()
        {
            var pretendenteQueAtendeCriterioDeRendaEIdade = PessoaBuilder.UmaPessoa().ComRenda(800).ComTipoPessoa(TipoPessoa.Pretendente).ComIdade(30).Build();
            var familia = FamiliaBuilder.UmaFamilia().ComPessoa(pretendenteQueAtendeCriterioDeRendaEIdade).Build();

            var pontuacao = _pontuador.ObterPontuacaoGeral(familia);

            Assert.AreEqual(7, pontuacao);
        }

        [Test]
        public void NaoDeveSomarCriteriosNaoAtendidos()
        {
            var pretendenteComMenorPontuacaoPossivel = PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Pretendente)
                .ComRenda(9999999).ComIdade(19).Build();
            var familia = FamiliaBuilder.UmaFamilia().ComPessoa(pretendenteComMenorPontuacaoPossivel).Build();

            var pontuacaoGeral = _pontuador.ObterPontuacaoGeral(familia);

            Assert.AreEqual(1, pontuacaoGeral);
        }

        
    }
}
