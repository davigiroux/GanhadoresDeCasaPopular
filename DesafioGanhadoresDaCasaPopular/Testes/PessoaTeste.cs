using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Testes
{
    public class PessoaTeste
    {

        [Test]
        public void DeveCriarPessoa()
        {
            var tipoDePessoa = TipoPessoa.Pretendente;
            var dataDeNascimento = new DateTime(1996, 02, 02);
            var valorDaRenda = 1800.00;

            var pessoa = new Pessoa(tipoDePessoa, dataDeNascimento, valorDaRenda);

            Assert.AreEqual(tipoDePessoa, pessoa.Tipo);
            Assert.AreEqual(dataDeNascimento, pessoa.DataDeNascimento);
            Assert.AreEqual(valorDaRenda, pessoa.Renda);
        }
    }
}
