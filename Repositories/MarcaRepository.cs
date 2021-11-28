using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class MarcaRepository : GenericRepositoy<Marca>
    {
        private AppDBContext _context;
        public List<Marca> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Marcas.Where(x => x.Nombre.ToUpper().Contains(nombre) && x.Borrado == false).ToList();
            }
        }

        public List<Marca> ExisteCrear(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Marcas.Where(x => x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
        public List<Marca> ExisteEditar(string nombre, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Marcas.Where(x => x.ID != id && x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
    }
}
