using System.Collections.Generic;

namespace ContaCorrente.Doman.Models
{
    public class CarteiraInvestimento
    {

        public double Total { get; set; }
        public bool TermoCondicao { get; set; }
        public List<Poupanca> Poupanca { get; set; }
        public List<RendaFixa> RendaFixa { get; set; }
        public List<FundoInvestimento> FundoInvestimento { get; set; }

        public bool adicionarInvestimento(Investimento investimento)
        {
            return true;
        }
        public bool editarInvestimento(Investimento investimento)
        {
            return true;
        }

        public bool resgatarInvestimento(Investimento investimento)
        {
            return true;
        }
        public bool verificarTipoInvestimento(Investimento investimento)
        {
            return true;
        }

    }
}