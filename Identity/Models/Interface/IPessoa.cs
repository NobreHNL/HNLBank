using Identity.Doman.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models.Interface
{
    public interface IPessoa
    {

        public bool CriarPessoa(string nome, string CPF_CNPJ, string CEP);
        public bool ValidarDados(Telefone celular);
        public bool ValidarDados(Email email);
        public Endereco AtualizarEndereco(Endereco endereco);
        public bool SalvarAssinatura(Assinatura assinatura);
        public Documento SalvarDocumento(Documento documento);



    }
}
