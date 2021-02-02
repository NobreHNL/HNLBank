using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models.Interface
{
    public interface IPessoaFisica
    {

        public bool ConfirmarDadosPessoais(PessoaFisica dadosPessoais);
        public bool SalvarSelfie(string selfie);
        public bool ValidarSelfie(string selfie);
        public bool FinalizarCadastro(bool termoECondicoes);
        public bool EnviarMensagemConfirmacao(Pessoa pessoa);

    }
}
