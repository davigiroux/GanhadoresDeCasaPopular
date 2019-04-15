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


        public Familia(List<Pessoa> pessoas)
        {
            Id = "0123" + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            _pessoas = pessoas;
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
    }
}
