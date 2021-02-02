using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente.Doman.Models.ValueObject
{
   public class Bank
    {
        public int Codbanco { get; set; }
        public string Nome { get; set; }
        public int CodAgencia{ get; set; }
        public string Agencia {get; set; }
    }
}
