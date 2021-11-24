using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Empleado : BaseEntity
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }   
        public int Codigo_Empleado { get; set; }
        public int CargoID { get; set; }
        public int DepartamentoID { get; set; }
        
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public double Edad
        {
            get
            {
                return DateTime.Now.Subtract(this.Fecha_Nacimiento).TotalDays / 365.25;
            }
        }
        public virtual List<Vehiculo> Vehiculos { get; set; }
        public virtual List<Entrega> Entregas { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}
