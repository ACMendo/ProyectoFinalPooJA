using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class DepartamentoRepository : GenericRepositoy<Departamento>
    {
        private AppDBContext _context;
        public List<Departamento> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Departamentos.Where(x => x.Nombre.ToUpper().Contains(nombre) && x.Borrado == false).ToList();
            }
        }

        public List<Departamento> ExisteCrear(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Departamentos.Where(x => x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
        public List<Departamento> ExisteEditar(string nombre, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Departamentos.Where(x => x.ID != id && x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
    }
}
