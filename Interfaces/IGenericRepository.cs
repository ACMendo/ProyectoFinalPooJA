using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Interfaces
{
    public interface IGenericRepository<T>
    {
        T Crear(T entity);
        List<T> Consultar(int id);
        IQueryable<T> ConsultarGenery(int id, params Expression<Func<T,object>>[] propiedades);
        OperationResult Actualizar(T entity);
        OperationResult Borrar(T entity);
    }
}
