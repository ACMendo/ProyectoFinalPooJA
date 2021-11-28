using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class PrioridadRepository : GenericRepositoy<Prioridad>
    {
        private AppDBContext _context;
        public List<Prioridad> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Prioridades.Where(x => x.Nombre.ToUpper().Contains(nombre) || x.Horas.ToString().Contains(nombre)
                                               && x.Borrado == false).ToList();
            }
        }
        public List<Prioridad> ExisteCrear(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Prioridades.Where(x => x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
        public List<Prioridad> ExisteEditar(string nombre, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Prioridades.Where(x => x.ID != id && x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
    }
}
