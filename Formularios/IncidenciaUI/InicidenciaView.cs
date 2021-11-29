using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Formularios.IncidenciaUI
{
    public class InicidenciaView
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public int TallerID { get; set; }
        public string  Taller { get; set; }
        public int VehiculoID { get; set; }
        public string Placa { get; set; }
        public string Chasis { get; set; }
    }
}
