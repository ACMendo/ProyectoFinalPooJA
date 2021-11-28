using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class ColorRepository : GenericRepositoy<Color>
    {
        private AppDBContext _context;
        public List<Color> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Colors.Where(x => x.Nombre.ToUpper().Contains(nombre)
                                               && x.Borrado == false).ToList();
            }
        }
        public List<Color> ExisteCrear(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Colors.Where(x => x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
        public List<Color> ExisteEditar(string nombre, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Colors.Where(x => x.ID != id && x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
    }
}
