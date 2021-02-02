using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Doman.Models.ValueObject
{
    public class Documento
    {
        public Documento() { }
        public Guid DocumentoId { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public DateTime Emissao { get; set; }
        public string UF { get; set; }
        public string ImagemFrente { get; set; }
        public string ImagemVenso { get; set; }

        public Documento ProcessarDocumento(Documento documento)
        {
            return null;
        }
        public bool ValidarDocumento(Documento documento)
        {
            return true;
        }
        public bool PegarDados(Documento documento)
        {
            return true;
        }

    }
}
