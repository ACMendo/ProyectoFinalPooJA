using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class Tipo_VehiculoRepository : GenericRepositoy<Tipo_Vehiculo>
    {
        private AppDBContext _context;
        public List<Tipo_Vehiculo> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Tipo_Vehiculos.Where(x => x.Nombre.ToUpper().Contains(nombre) || x.Descripcion.ToUpper().Contains(nombre)
                                               && x.Borrado == false).ToList();
            }
        }
        public List<Tipo_Vehiculo> ExisteCrear(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return _context.Tipo_Vehiculos.Where(x => x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
        public List<Tipo_Vehiculo> ExisteEditar(string nombre, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Tipo_Vehiculos.Where(x => x.ID != id && x.Nombre.ToUpper() == nombre && x.Borrado == false).ToList();
            }
        }
    }
}
