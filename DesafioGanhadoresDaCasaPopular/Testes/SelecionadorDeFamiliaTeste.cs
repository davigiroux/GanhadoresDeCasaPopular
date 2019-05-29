using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Builder;
using DesafioGanhadoresDaCasaPopular.Domínio;
using ExpectedObjects.Reporting;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    public class SelecionadorDeFamiliaTeste
    {
        [Test]
        public void DeveSelecionarFamiliasElegiveisParaGanharUmaCasa()
        {
            var familiasQueSeCandidataram = new List<Familia>()
            {
                FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Pretendente).Build()).ComStatusFamilia(StatusFamilia.CadastroImcompletoOuIrregular).Build(),
                FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Pretendente).Build()).ComStatusFamilia(StatusFamilia.JaPossuiUmaCasa).Build(),
                FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Pretendente).Build()).ComStatusFamilia(StatusFamilia.ElegivelParaSelecao).Build(),
                FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Pretendente).Build()).ComStatusFamilia(StatusFamilia.SelecionadaEmOutroProcessoDeSelecao).Build(),
                FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Pretendente).Build()).ComStatusFamilia(StatusFamilia.ElegivelParaSelecao).Build(),
                FamiliaBuilder.UmaFamilia().ComPessoa(PessoaBuilder.UmaPessoa().ComTipoPessoa(TipoPessoa.Pretendente).Build()).ComStatusFamilia(StatusFamilia.ElegivelParaSelecao).Build(),
            };
            const int quantidadeDeFamiliasSelecionadasEsperada = 3;
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
            var selecionador = new SelecionadorDeFamilias(new Pontuador(criterios));

            var familiasSelecionadas = selecionador.ObterFamiliasSelecionadas(familiasQueSeCandidataram);

            Assert.AreEqual(quantidadeDeFamiliasSelecionadasEsperada, familiasSelecionadas.Count);
        }
    }
}
