using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Departamento: BaseEntity
    {
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
