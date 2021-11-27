using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using ProyectoFinalPooJA.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Repositories
{
    public class GenericRepositoy<T> : IGenericRepository<T> where T : BaseEntity
    {
        private AppDBContext _context;
        private DbSet<T> _set;
        public GenericRepositoy()
        {
            _context = new AppDBContext();
            _set = _context.Set<T>();
        }

        public T Crear(T entity)
        {
            _set.Add(entity);
            //default fechamodificacion no me acepto el nulo 
            entity.Borrado = false;
            entity.Estatus = "A";
            entity.Fecha_Registro = DateTime.Now;
            //entity.Fecha_Modificacion = new DateTime(1999, 1, 1);
            _context.SaveChanges();
            return entity;
        }
        public List<T> Consultar(int id)
        {
            if (id.Equals(0)) return _set.Where(x => x.Borrado == false).ToList();
            else return _set.Where(x => x.Borrado == false && x.ID == id).ToList();
        }

        public IQueryable<T> ConsultarGenery(int id, params Expression<Func<T, object>>[] propiedades)
        {
            var query = _set.AsQueryable();
            foreach (var prop in propiedades)
            {
                query = query.Where(x=>x.Borrado== false).Include(prop);
            }
            if (id.Equals(0)) return query.Where(x => x.Borrado == false);
            else return query.Where(x => x.Borrado == false && x.ID == id);
        }
        public OperationResult Borrar(int id)
        {
            try
            {
                var datos = Consultar(id)[0];
                _context.Entry(datos).State = EntityState.Modified;
                datos.Borrado = true;
                datos.Fecha_Modificacion = DateTime.Now;
                datos.Estatus = "E";
                _context.SaveChanges();
                return new OperationResult { Success = true, Message = "!Registro Borrado!" };
            }
            catch (Exception ex)
            {
                return new OperationResult { Success = false, Message = "No se borro el registro" + ex.Message };
            }
        }
        public OperationResult Actualizar(T entity)
        {
            try
            {    
                _context.Entry(entity).State = EntityState.Modified;
                entity.Fecha_Modificacion = DateTime.Now;
                _context.SaveChanges();
                return new OperationResult { Success = true, Message = "!Registro Actualizado!" };
            }
            catch (Exception ex)
            {
                return new OperationResult { Success = false, Message = "No se actualizo el registro" + ex.Message };
            }
        }
    }
}
