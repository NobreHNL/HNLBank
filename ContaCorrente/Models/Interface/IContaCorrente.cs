using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente.Doman.Models.Interface
{
    public interface IContaCorrente
    {
        public bool CriarContaCorrente();
        public bool envirarDadosContaCorrente(ContaCorrente conta, Usuario usuario);

    }
}
