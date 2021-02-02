using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models.ValueObject
{
    public class Assinatura
    {
        public Assinatura() { }
        public string ImagemAssinatura { get; set; }

        public bool ProcessarAssinatura(Assinatura assinatura)
        {
            return true;
        }

        public bool ValidarAssinatura(Assinatura assinatura)
        {
            return true;
        }

    }
}
