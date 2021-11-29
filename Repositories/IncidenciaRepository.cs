using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class IncidenciaRepository : GenericRepositoy<Incidencia>
    {
        private AppDBContext _context;
        public List<Incidencia> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return ConsultarGenery(0, x => x.Vehiculo, x => x.Taller).ToList().Where(x => x.Taller.Nombre.ToUpper().Contains(nombre)
                                                                                         || x.Descripcion.ToUpper().Contains(nombre)
                                                                                         || x.Vehiculo.Chasis.ToUpper().Contains(nombre)
                                                                                         || x.Vehiculo.Placa.ToUpper().Contains(nombre)
                                                                                         || x.Fecha_Salida.ToString().Contains(nombre)
                                                                                         || x.Fecha_Entrada.ToString().Contains(nombre)
                                                                                         && x.Vehiculo.Mantenimiento == true).ToList();
            }
        }
        public List<Incidencia> ExisteCrear(string chasis)
        {
            using (_context = new AppDBContext())
            {
                return ConsultarGenery(0, x => x.Vehiculo, x => x.Taller).Where(x => x.Vehiculo.Chasis.ToUpper() == chasis   && x.Vehiculo.Mantenimiento==true).ToList();
            }
        }
        public List<Incidencia> ExisteEditar(string chasis, int id)
        {
            using (_context = new AppDBContext())
            {
                return ConsultarGenery(0, x => x.Vehiculo, x => x.Taller).Where(x => x.ID != id && x.Vehiculo.Chasis.ToUpper() == chasis && x.Vehiculo.Mantenimiento == true).ToList();
            }
        }

    }
}
