using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Formularios.EntregaUI
{
    public class EntregaView
    {
        public int ID { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Regreso { get; set; }
        public string Descripcion { get; set; }
        public decimal Peso { get; set; }
        public int EmpleadoID { get; set; }
        public string Empleado { get; set; }
        public int ClienteID { get; set; }
        public string Cliente { get; set; }
        public int PrioridadID { get; set; }
        public string Prioridad { get; set; }
    }
}
