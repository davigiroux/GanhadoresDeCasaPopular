namespace DesafioGanhadoresDaCasaPopular.Testes
{

    public enum TipoPessoa { Pretendente, Cônjugue, Dependente }
    public class Pessoa
    {
        public TipoPessoa Tipo { get; private set; }

        public Pessoa(TipoPessoa tipo)
        {
            Tipo = tipo;
        }
    }
}