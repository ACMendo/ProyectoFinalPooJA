using ProyectoFinalPooJA.Datos.Context;
using ProyectoFinalPooJA.Datos.Entities;
using ProyectoFinalPooJA.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        public OperationResult Borrar(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                entity.Borrado = true;
                entity.Fecha_Modificacion = DateTime.Now;
                entity.Estatus = "E";
                _context.SaveChanges();
                return new OperationResult { Success = true, Message = "Registro Borrado" };
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
                return new OperationResult { Success = true, Message = "Registro Actualizado" };
            }
            catch (Exception ex)
            {
                return new OperationResult { Success = false, Message = "No se actualizo el registro" + ex.Message };
            }
        }
    }
}
