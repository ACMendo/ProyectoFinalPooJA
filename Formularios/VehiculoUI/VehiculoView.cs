using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Formularios.VehiculoUI
{
    public class VehiculoView
    {
        public int ID { get; set; }
        public string Chasis { get; set; }
        public string Placa { get; set; }
        [DisplayName("Transmisión")]
        public string Transmision { get; set; }
        public string Combustible { get; set; }
        public bool Mantenimiento { get; set; }
        [DisplayName("Año")]
        public string Anio { get; set; }
        public int ModeloID { get; set; }
        public int ColorID { get; set; }
        public int EmpleadoID { get; set; }
        public int Tipo_VehiculoID { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Empleado { get; set; }
        [DisplayName("Tipo Vehículo")]
        public string Tipo_Vehiculo { get; set; }
        //public List<Incidencia> Incidencias { get; set; }
    }
}
