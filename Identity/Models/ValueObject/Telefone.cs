using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models.ValueObject
{
    public class Telefone
    {
        public Telefone() { }
        public int DDD { get; set; }
        public int NumeroTelefone { get; set; }

        public bool ValidarTelefone(int DDD, int NumeroTelefone)
        {
            return true;
        }
        public bool ValidarCodigo(string codigo)
        {
            return true;
        }
    }
}
