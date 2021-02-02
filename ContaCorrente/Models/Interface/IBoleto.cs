using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente.Doman.Models.Interface
{
    public interface IBoleto
    {
        public Boleto GerarPDF(Boleto boleto);
        public PDF CriarBoleto(Boleto boleto);
    }
}
