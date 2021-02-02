using System.Collections.Generic;

namespace ContaCorrente.Doman.Models.Interface
{
    public class Pagador
    {

        public string Nome { get; set; }
        public int CPF_CNPJ { get; set; }

        public List<Pagador> GetPagador()
        {
            return null;
        }
        public List<Pagador> addPagador(Pagador pagador)
        {
            return null;
        }
        public List<Pagador> removePagador(int pagadorId)
        {
            return null;
        }

    }
}