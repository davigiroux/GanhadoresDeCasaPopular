﻿using System;
using System.Collections.Generic;
using DesafioGanhadoresDaCasaPopular.Testes;

namespace DesafioGanhadoresDaCasaPopular.Domínio
{
    public class Familia
    {
        private string Id { get; }
        private readonly List<Pessoa> _pessoas;
        public StatusFamilia Status { get; private set; }


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
            if (PodeAdicionarPessoa(pessoa))
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
                rendaTotal += pessoa.Renda;
            }

            return rendaTotal;
        }

        public int ObterQuantidadeDeDependentes()
        {
            return _pessoas.FindAll(pessoa => pessoa.Tipo == TipoPessoa.Dependente).Count;
        }

        public int ObterQuantidadeDeDependentesComMenosDe19Anos()
        {
            return _pessoas.FindAll(pessoa => pessoa.Tipo == TipoPessoa.Dependente && pessoa.Idade <= 18).Count;
        }
    }
}
