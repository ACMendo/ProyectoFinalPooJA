using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Formularios.EmpleadoUI
{
    public class EmpleadoView
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int Codigo_Empleado { get; set; }
        public int CargoID { get; set; }
        public string Cargo { get; set; }
        public int DepartamentoID { get; set; }
        public string Departameto { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public double Edad { get; set; }
    }
}
