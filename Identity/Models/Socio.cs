using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models
{
    class Socio : PessoaFisica

    {
        public Socio()
        {
        }

        public string Status { get; set; }

        public int Porcentagem { get; set; }


    }
}
