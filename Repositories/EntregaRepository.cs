using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class EntregaRepository : GenericRepositoy<Entrega>
    {
        public Empleado ObtenerEmpleado(int id)
        {
            return new EmpleadoRepository().Consultar(id)[0];
        }
        public Prioridad ObtenerPrioridad(int id)
        {
            return new PrioridadRepository().Consultar(id)[0];
        }
        public Cliente ObtenerCliente(int id)
        {
            return new ClienteRepository().Consultar(id)[0];
        }
    }
}
