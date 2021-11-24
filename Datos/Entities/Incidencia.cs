using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Incidencia : BaseEntity
    {
        public string Descripcion { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public int TallerID { get; set; }
        public int VehiculoID { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public virtual Taller Taller { get; set; }
    }
}
