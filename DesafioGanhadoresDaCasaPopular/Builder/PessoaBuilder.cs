using System;
using DesafioGanhadoresDaCasaPopular.Testes;

namespace DesafioGanhadoresDaCasaPopular.Builder
{
    public class PessoaBuilder
    {
        private TipoPessoa _tipoPessoa = TipoPessoa.Pretendente;
        private DateTime _dataNascimento = new DateTime(1990, 06, 15);
        private double _renda = 800;

        public static PessoaBuilder UmaPessoa()
        {
            return new PessoaBuilder();
        }

        public Pessoa Build()
        {
            var pessoa = new Pessoa(_tipoPessoa, _dataNascimento, _renda);
            return pessoa;
        }

        public PessoaBuilder ComRenda(double renda)
        {
            _renda = renda;
            return this;
        }

        public PessoaBuilder ComDataDeNascimento(DateTime dataDeNascimento)
        {
            _dataNascimento = dataDeNascimento;
            return this;
        }

        public PessoaBuilder ComTipoPessoa(TipoPessoa tipoPessoa)
        {
            _tipoPessoa = tipoPessoa;
            return this;
        }

        public PessoaBuilder ComIdade(int idade)
        {
            _dataNascimento = DateTime.Now.AddYears(-idade);
            return this;
        }
    }
}
