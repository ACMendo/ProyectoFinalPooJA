using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Formularios.EmpleadoUI
{
    public class EmpleadoView
    {
        public int ID { get; set; }
        [DisplayName("Código Empleado")]
        public int Codigo_Empleado { get; set; }

        [DisplayName("Nombre Completo")]
        public string Nombre { get; set; }

        [DisplayName("Cédula")]
        public string Cedula { get; set; }

        public string Correo { get; set; }

        [DisplayName("Teléfono")]
        public string Telefono { get; set; }
        public int CargoID { get; set; }
        public string Cargo { get; set; }
        public int DepartamentoID { get; set; }
        public string Departameto { get; set; }
        
        [DisplayName("Fecha de Ingreso")]
        public DateTime Fecha_Ingreso { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        public DateTime Fecha_Nacimiento { get; set; }
        public double Edad { get; set; }
    }
}
