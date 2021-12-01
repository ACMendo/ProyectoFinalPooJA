using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Formularios.ReportesUI
{
    public class ReporteView
    {
        public string Destino { get; set; }
        [DisplayName("Fecha de Salida")]
        public DateTime Fecha_Salida { get; set; }
        [DisplayName("Fecha de Regreso")]
        public DateTime Fecha_Regreso { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string Peso { get; set; }
        public string Empleado { get; set; }
        public string Cliente { get; set; }
        public string Prioridad { get; set; }
    }
}
