using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerApp.Entities
{
    public class Gerencia
    {
        public int GerenciaId { get; set; }
        public string Apoderado { get; set; }
        public string NombreGerencia { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Abreviatura { get; set; }

    }
}
