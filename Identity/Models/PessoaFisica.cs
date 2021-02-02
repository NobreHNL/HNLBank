using Identity.Doman.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models
{
    public class PessoaFisica : IPessoaFisica
    {
        public PessoaFisica() { }
        public string CPF { get; set; }
        public string Selfie { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNacimento { get; set; }
        public string EstadoCivil { get; set; }
        public string NomeConjuge { get; set; }
        public string UFNaturalidade { get; set; }
        public string Naturalidade { get; set; }

        public bool ConfirmarDadosPessoais(PessoaFisica dadosPessoais)
        {
            return true;
        }

        public bool SalvarSelfie(string selfie)
        {
            return true;
        }

        public bool ValidarSelfie(string selfie)
        {
            return true;
        }

        public bool FinalizarCadastro(bool termoECondicoes)
        {
            return true;
        }
        public bool EnviarMensagemConfirmacao(Pessoa pessoa)
        {
            return true;
        }
    }
}
