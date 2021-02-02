using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models.Interface
{
    public interface IPessoaJuridica
    {

        public bool FinalizarCadastro(bool termoECondicoes);
        public bool EnviarMensagemConfirmacao(Pessoa pessoa);
    }
}

