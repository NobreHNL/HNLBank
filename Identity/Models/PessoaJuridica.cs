using Identity.Doman.Models.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models
{
    class PessoaJuridica : IPessoaJuridica
    {
        public PessoaJuridica () { }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSacial { get; set; }
        public bool SociedadeIndividual { get; set; }
        public List<Socio> Socios { get; set; }
        public DateTime InscricaoDate { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoEstadual { get; set; }

        public bool EnviarMensagemConfirmacao(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public bool FinalizarCadastro(bool termoECondicoes)
        {
            throw new NotImplementedException();
        }
    }
}
