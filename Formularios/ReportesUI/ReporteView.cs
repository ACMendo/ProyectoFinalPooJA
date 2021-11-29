using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Formularios.ReportesUI
{
    public class ReporteView
    {
        public string Destino { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Regreso { get; set; }
        public string Descripcion { get; set; }
        public string Peso { get; set; }
        public string Empleado { get; set; }
        public string Cliente { get; set; }
        public string Prioridad { get; set; }
    }
}
