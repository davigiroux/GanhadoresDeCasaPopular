using System;

namespace DesafioGanhadoresDaCasaPopular.Testes
{

    public enum TipoPessoa { Pretendente, Cônjugue, Dependente }
    public class Pessoa
    {
        public TipoPessoa Tipo { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public double Renda { get; private set; }

        public Pessoa(TipoPessoa tipo, DateTime dataDeNascimento, double valorDaRenda)
        {
            Tipo = tipo;
            DataDeNascimento = dataDeNascimento;
            Renda = valorDaRenda;
        }
    }
}