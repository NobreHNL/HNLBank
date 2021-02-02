namespace ContaCorrente.Doman.Models
{
    public interface IIvestimento
    {
        public Investimento criar(Investimento investimento);
        public Investimento editar(Investimento investimento);
        public Investimento detalhe(Investimento investimento);
        public Investimento resgastar(Investimento investimento);
    }
}