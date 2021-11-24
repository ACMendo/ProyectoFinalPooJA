using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Modelo : BaseEntity
    {
        public string Nombre { get; set; }
        public int MarcaID { get; set; }
        public Marca Marca { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}
