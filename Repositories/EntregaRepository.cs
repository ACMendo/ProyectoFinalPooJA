using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class EntregaRepository : GenericRepositoy<Entrega>
    {
        private AppDBContext _context;
        public List<Entrega> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                var datos= ConsultarGenery(0, x => x.Prioridad, x => x.Empleado, x => x.Cliente).ToList();
                string h = datos[0].Fecha_Salida.ToString().ToUpper(); ;
                return ConsultarGenery(0, x => x.Prioridad, x => x.Empleado, x => x.Cliente).Where(x => x.Cliente.Nombre.ToUpper().Contains(nombre)
                                                                                          || x.Descripcion.ToUpper().Contains(nombre)
                                                                                          || x.Destino.ToUpper().Contains(nombre)
                                                                                          || x.Empleado.Nombre.ToUpper().Contains(nombre)
                                                                                          || x.Prioridad.Nombre.ToString().ToUpper().Contains(nombre)
                                                                                          || x.Peso.ToString().Contains(nombre)
                                                                                          || x.Fecha_Salida.ToString().Contains(nombre)
                                                                                          || x.Fecha_Regreso.ToString().Contains(nombre)).ToList();
            }
        }
        //public List<Entrega> ExisteCrear(string chasis, string placa)
        //{
        //    using (_context = new AppDBContext())
        //    {
        //        return _context.Vehiculos.Where(x => (x.Placa.ToUpper() == placa || x.Chasis.ToString() == chasis) && x.Borrado == false).ToList();
        //    }
        //}
        //public List<Vehiculo> ExisteEditar(string chasis, string placa, int id)
        //{
        //    using (_context = new AppDBContext())
        //    {
        //        return _context.Vehiculos.Where(x => x.ID != id && (x.Placa.ToUpper() == placa || x.Chasis.ToString() == chasis) && x.Borrado == false).ToList();
        //    }
        //}
    }
}
