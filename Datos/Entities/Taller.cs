using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Taller : BaseEntity
    {
        public string Nombre { get; set; }
        [DisplayName("Dirección")]
        public string Direccion { get; set; }
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }
        public List<Incidencia> Incidencias { get; set; }
    }
}
