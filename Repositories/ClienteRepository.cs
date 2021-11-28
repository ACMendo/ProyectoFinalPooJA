using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class ClienteRepository : GenericRepositoy<Cliente>
    {
        private AppDBContext _context;
        public List<Cliente> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Clientes.Where(x => x.Nombre.ToUpper().Contains(nombre)
                                                || x.Direccion.ToUpper().Contains(nombre)
                                                || x.Correo.ToUpper().Contains(nombre)
                                                || x.Telefono.ToUpper().Contains(nombre)
                                                || x.Identificacion.ToUpper().Contains(nombre)
                                                || x.Tipo_Identificacion.ToUpper().Contains(nombre) && x.Borrado == false).ToList();
            }
        }
        public List<Cliente> ExisteCrear(string identificacion)
        {
            using (_context = new AppDBContext())
            {
                return _context.Clientes.Where(x => x.Identificacion.ToUpper() == identificacion && x.Borrado == false).ToList();
            }
        }
        public List<Cliente> ExisteEditar(string identificacion, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Clientes.Where(x => x.ID != id && x.Identificacion.ToUpper() == identificacion && x.Borrado == false).ToList();
            }
        }
    }
}
