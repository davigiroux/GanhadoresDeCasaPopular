using System;

namespace DesafioGanhadoresDaCasaPopular.Testes
{

    public enum TipoPessoa { Pretendente, Cônjugue, Dependente }
    public class Pessoa
    {
        public string Id { get; private set; }
        public TipoPessoa Tipo { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public Renda Renda { get; private set; }

        public Pessoa(TipoPessoa tipo, DateTime dataDeNascimento, double valorDaRenda)
        {
            Id = "012" + DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            Tipo = tipo;
            DataDeNascimento = dataDeNascimento;
            Renda = new Renda(valorDaRenda);
        }
    }
}