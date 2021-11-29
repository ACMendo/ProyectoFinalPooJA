using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Formularios.EntregaUI
{
    public class EntregaView
    {
        public int ID { get; set; }
        public string Destino { get; set; }
        [DisplayName("Fecha Salida")]
        public DateTime Fecha_Salida { get; set; }
        [DisplayName("Fecha Regreso")]
        public DateTime Fecha_Regreso { get; set; }
        [DisplayName("Descripción")]
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
