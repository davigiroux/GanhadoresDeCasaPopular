using System;
using System.Collections.Generic;
using System.Text;
using DesafioGanhadoresDaCasaPopular.Testes;
using NUnit.Framework;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    public class Familia
    {
        private string Id { get; }
        private readonly List<Pessoa> _pessoas;
        private StatusFamilia Status { get; set; }


        public Familia(List<Pessoa> pessoas, StatusFamilia status)
        {
            Id = "0123" + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            _pessoas = pessoas;
            this.Status = status;
        }

        public Pessoa ObterPessoaPretendente()
        {
            return _pessoas.Find(p => p.Tipo == TipoPessoa.Pretendente);
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            if(PodeAdicionarPessoa(pessoa))
                _pessoas.Add(pessoa);
            else
            {
                throw new Exception("É necessário cadastrar uma pessoa pretendente");
            }
        }

        private bool PodeAdicionarPessoa(Pessoa pessoa)
        {
            return ExistePessoaPretendenteCadastrada() 
                   || (!ExistePessoaPretendenteCadastrada() && pessoa.Tipo == TipoPessoa.Pretendente);
        }

        private bool ExistePessoaPretendenteCadastrada()
        {
            return ObterPessoaPretendente() != null;
        }

        public double ObterRendaTotal()
        {
            double rendaTotal = 0;
            foreach (var pessoa in _pessoas)
            {
                rendaTotal += pessoa.Renda.Valor;
            }

            return rendaTotal;
        }
    }
}
