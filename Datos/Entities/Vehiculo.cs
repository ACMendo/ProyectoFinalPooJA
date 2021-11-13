using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Vehiculo : BaseEntity
    {
        public string Chasis { get; set; }
        public string Placa { get; set; }
        public string Transmision { get; set; }
        public string Combustible { get; set; }
        public bool Mantenimiento { get; set; }
        public string Anio { get; set; }
        public int ModeloID { get; set; }
        public int ColorID { get; set; }
        public int EmpleadoID { get; set; }
        public int Tipo_VehiculoID { get; set; }
        public Modelo Modelo { get; set; }
        public Color Color { get; set; }
        public Empleado Empleado { get; set; }
        public Tipo_Vehiculo Tipo_Vehiculo { get; set; }
        public List<Incidencia> Incidencias { get; set; }

        //public Color MyProperty { get; set; }
    }
}
