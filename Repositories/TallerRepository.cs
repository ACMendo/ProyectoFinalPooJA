using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class TallerRepository : GenericRepositoy<Taller>
    {
        private AppDBContext _context;
        public List<Taller> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Talleres.Where(x => x.Nombre.ToUpper().Contains(nombre) || x.Direccion.ToUpper().Contains(nombre)
                                               || x.Telefono.ToUpper().Contains(nombre)
                                               && x.Borrado == false).ToList();
            }
        }
        public List<Taller> ExisteCrear(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Talleres.Where(x => x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
        public List<Taller> ExisteEditar(string nombre, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Talleres.Where(x => x.ID != id && x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
    }
}
