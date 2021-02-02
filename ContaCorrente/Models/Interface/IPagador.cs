using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente.Doman.Models.Interface
{
    public interface IPagador
    {
        public List<Pagador> GetPagador();
        public List<Pagador> addPagador(Pagador pagador);
        public List<Pagador> removePagador(int pagadorId);
    }
}
