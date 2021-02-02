using Identity.Doman.Models.Interface;
using Identity.Doman.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models
{
   public class Pessoa : IPessoa
    {
        public Pessoa() { }
        public Email Email { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Assinatura Assinatura { get; set; }
        public bool TermoCondicional { get; set; }
        public Documento Documento { get; set; }
        public Usuario Usuario { get; set; }

        public bool CriarPessoa(string nome, string CPF_CNPJ, string CEP)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDados(Telefone celular)
        {
            return true;
        }
        public bool ValidarDados(Email email)
        {
            return true;
        }
        public Endereco AtualizarEndereco(Endereco endereco)
        {
            return null;
        }
        public bool SalvarAssinatura(Assinatura assinatura)
        {
            return true;
        }
        public Documento SalvarDocumento(Documento documento)
        {
            return null;
        }
    }
}
