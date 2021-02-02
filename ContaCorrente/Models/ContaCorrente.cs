using ContaCorrente.Doman.Models.Interface;
using ContaCorrente.Doman.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente.Doman.Models
{
    public class ContaCorrente : IContaCorrente

    {
        public ContaCorrente() { }
        public Bank bank { get; set; }
        public int Conta { get; set; }
        public int Digito { get; set; }
        public double Saldo { get; set; }
        public List<Cartao> Cartao { get; set; }
        public List<Boleto> Boleto { get; set; }
        public List<Convite> Convite { get; set; }
        public List<Movimentacao> Movimentacao { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public CarteiraInvestimento Investimento { get; set; }

        public bool CriarContaCorrente()
        {
            return true;
        }
        public bool envirarDadosContaCorrente(ContaCorrente conta, Usuario usuario)
        {
            return true;
        }
    }
}
