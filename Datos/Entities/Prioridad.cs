using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Datos.Entities
{
    public class Prioridad : BaseEntity
    {
        public string Nombre { get; set; }
        public int Horas { get; set; }
        public virtual List<Entrega> Entregas { get; set; }
    }
}
