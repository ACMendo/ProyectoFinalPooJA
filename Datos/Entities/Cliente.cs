using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nombre { get; set; }
        [DisplayName("Dirección")]
        public string Direccion { get; set; }
        public string Correo { get; set; }
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }
        [DisplayName("Identificación")]
        public string Identificacion { get; set; }
        [DisplayName("Tipo Identificación")]
        public string Tipo_Identificacion { get; set; }
        public List<Entrega> Entregas { get; set; }
        
    }
}
