using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente.Doman.Models.Interface
{
    public interface ICarteiraInvestimento
    {

        public bool adicionarInvestimento(Investimento investimento);
        public bool editarInvestimento(Investimento investimento);
        public bool resgatarInvestimento(Investimento investimento);
        public bool verificarTipoInvestimento(Investimento investimento);
      

    }
}
