using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public string Estatus { get; set; }
        public bool Borrado { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }

        //Estatus, Borrado, FechaRegistro, FechaModificacion.
    }
}
