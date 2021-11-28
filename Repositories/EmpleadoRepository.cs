using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class EmpleadoRepository : GenericRepositoy<Empleado>
    {
        private AppDBContext _context;
        public List<Empleado> Filtro(string nombre)
        {
            using (_context = new AppDBContext())
            {
                return ConsultarGenery(0, x => x.Departamento, x => x.Cargo).Where(x => x.Nombre.ToUpper().Contains(nombre)
                                                                                    || x.Telefono.ToUpper().Contains(nombre)
                                                                                    || x.Cargo.Nombre.ToUpper().Contains(nombre)
                                                                                    || x.Cedula.ToUpper().Contains(nombre)
                                                                                    || x.Codigo_Empleado.ToString().ToUpper().Contains(nombre)
                                                                                    || x.Correo.ToUpper().Contains(nombre)
                                                                                    || x.Departamento.Nombre.ToUpper().Contains(nombre)
                                                                                    || x.Fecha_Ingreso.ToString().ToUpper().Contains(nombre)
                                                                                    || x.Fecha_Nacimiento.ToString().ToUpper().Contains(nombre)).ToList();
            }
        }
        public List<Empleado> ExisteCrear(string cedula, string codigo)
        {
            using (_context = new AppDBContext())
            {
                return _context.Empleados.Where(x => (x.Cedula.ToUpper() == cedula || x.Codigo_Empleado.ToString() == codigo) && x.Borrado == false).ToList();
            }
        }
        public List<Empleado> ExisteEditar(string cedula, string codigo, int id)
        {
            using (_context = new AppDBContext())
            {
                return _context.Empleados.Where(x => x.ID != id && (x.Cedula.ToUpper() == cedula || x.Codigo_Empleado.ToString() == codigo) && x.Borrado == false).ToList();
            }
        }
    }
}
