using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Tipo_Vehiculo : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}
