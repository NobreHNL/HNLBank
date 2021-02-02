using System;

namespace ContaCorrente.Doman.Models
{
    public class Movimentacao
    {
        public TipoMovimentacaoEnum TipoMovimentacao { get; set; }
        public float Valor { get; set; }
        public DateTime Data { get; set; }
        public bool GerenciarMovimentacao(Movimentacao movimentacao)
        {
            return true;
        }
    }
}