using System;

namespace DesafioGanhadoresDaCasaPopular.Testes
{

    public enum TipoPessoa { Pretendente, Cônjugue, Dependente }
    public class Pessoa
    {
        public TipoPessoa Tipo { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public double Renda { get; private set; }
        public int Idade
        {
            get
            {
                var idade = DateTime.Now.Year - DataDeNascimento.Year;
                if (DateTime.Now.Month < DataDeNascimento.Month || (DateTime.Now.Month == DataDeNascimento.Month && DateTime.Now.Day < DataDeNascimento.Day))
                    idade = idade - 1;

                return idade;
            }
        }

        public Pessoa(TipoPessoa tipo, DateTime dataDeNascimento, double valorDaRenda)
        {
            Tipo = tipo;
            DataDeNascimento = dataDeNascimento;
            Renda = valorDaRenda;
        }
    }
}