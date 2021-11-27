using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class CargoRepository : GenericRepositoy<Cargo>
    {
        private AppDBContext _context;
        public List<Cargo> BuscarPorNombre(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Cargos.Where(x => x.Nombre.ToUpper().Contains(nombre) && x.Borrado==false).ToList();
            }
        }

        public List<Cargo> ExisteCrear(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Cargos.Where(x => x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
        public List<Cargo> ExisteEditar(string nombre, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Cargos.Where(x => x.ID != id && x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
    }
}
