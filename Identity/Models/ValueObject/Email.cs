using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models.ValueObject
{
    public class Email
    {
        public Email() { }
        public string EnderecoEmail { get; set; }

        public bool ValidarEmail(string EnderecoEmail)
        {
            return true;
        }
        public bool ValidarCodigo(string codigo)
        {
            return true;
        }

    }

}

