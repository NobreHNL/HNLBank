using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models.ValueObject
{
    public class Endereco
    {
        public Endereco() { }
        public string CEP { get; set; }
        public string Tipo { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public Endereco CriarEndereco(string cep)
        {
            return null;
        }
        public Endereco AtualizarEndereco(Endereco endereco)
        {
            return null;
        }

    }
}
