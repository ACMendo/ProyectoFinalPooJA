using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class ModeloRepository : GenericRepositoy<Modelo>
    {
        private AppDBContext _context;
        public List<Modelo> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return ConsultarGenery(0, x => x.Marca).Where(x => x.Nombre.ToUpper().Contains(nombre)
                                        || x.Marca.Nombre.ToUpper().Contains(nombre)).ToList();
            }
        }
        public List<Modelo> ExisteCrear(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Modelos.Where(x => x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
        public List<Modelo> ExisteEditar(string nombre, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Modelos.Where(x => x.ID != id && x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
    }
}
