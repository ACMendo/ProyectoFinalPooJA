using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Color : BaseEntity
    {
        public string Nombre { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}
