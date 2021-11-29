using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class VehiculoRepository : GenericRepositoy<Vehiculo>
    {
        private AppDBContext _context;
        public List<Vehiculo> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return ConsultarGenery(0, x => x.Color, x => x.Tipo_Vehiculo,x=>x.Modelo,x=>x.Empleado).Where(x => x.Chasis.ToUpper().Contains(nombre)
                                                                                    || x.Placa.ToUpper().Contains(nombre)
                                                                                    || x.Color.Nombre.ToUpper().Contains(nombre)
                                                                                    || x.Empleado.Nombre.ToUpper().Contains(nombre)
                                                                                    || x.Tipo_Vehiculo.Nombre.ToString().ToUpper().Contains(nombre)
                                                                                    || x.Modelo.Nombre.ToUpper().Contains(nombre)
                                                                                    || x.Transmision.ToUpper().Contains(nombre)
                                                                                    || x.Combustible.ToString().ToUpper().Contains(nombre)
                                                                                    || x.Anio.ToString().ToUpper().Contains(nombre)).ToList();
            }
        }
        public List<Vehiculo> ExisteCrear(string chasis, string placa)
        {
            using (_context = new AppDBContext())
            {
                return _context.Vehiculos.Where(x => (x.Placa.ToUpper() == placa || x.Chasis.ToString() == chasis) && x.Borrado == false).ToList();
            }
        }
        public List<Vehiculo> ExisteEditar(string chasis, string placa, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Vehiculos.Where(x => x.ID != id && (x.Placa.ToUpper() == placa || x.Chasis.ToString() == chasis) && x.Borrado == false).ToList();
            }
        }
    }
}
