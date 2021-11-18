using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Identificacion { get; set; }
        public string Tipo_Identificacion { get; set; }
        public List<Entrega> Entregas { get; set; }
        
    }
}
