using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente.Doman.Models
{
    public class Investimento : IIvestimento
    {

        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public TipoEnum TipoInvestimento { get; set; }

        public Investimento criar(Investimento investimento)
        {
            return null;
        }
        public Investimento editar(Investimento investimento)
        {
            return null;
        }
        public Investimento detalhe(Investimento investimento)
        {
            return null;
        }
        public Investimento resgastar(Investimento investimento)
        {
            return null;
        }
    }
}
