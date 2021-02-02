using System;

namespace ContaCorrente.Doman.Models.Interface
{
    public class Boleto
    {

        public double Valor { get; set; }
        public string CodigoBarra { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Beneficiario { get; set; }
        public string CPF_CNPJ { get; set; }
        public Pagador Pagador { get; set; }
        public long NumeroDoc { get; set; }
        public DateTime DataEmissao { get; set; }
        public statusEnum Status { get; set; }

        public Boleto GerarPDF(Boleto boleto)
        {
            return null;
        }

        public PDF CriarBoleto(Boleto boleto)
        {
            return null;
        }
    }
}