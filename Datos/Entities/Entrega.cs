using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Entrega : BaseEntity
    {
        public string Destino { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Regreso { get; set; }
        public string Descripcion { get; set; }
        public decimal Peso { get; set; }
        public int EmpleadoID { get; set; }
        public int ClienteID { get; set; }
        public int PrioridadID { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Prioridad Prioridad { get; set; }
    }
}
