using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerApp.Entities
{
    public class Carta
    {
        public int CartaId { get; set; }
        public string Codigo { get; set; }
        public int GerenciaId { get; set; }
        public string Asunto { get; set; }
        public string Destinatario { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
