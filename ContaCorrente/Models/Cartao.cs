using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente.Doman.Models
{
    public class Cartao
    {
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Bandeira { get; set; }
        public int CodigoVerificacao { get; set; }
        public List<Movimentacao> Movimentacao { get; set; }
        public TipoCartaoEnum TipoCartao { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
