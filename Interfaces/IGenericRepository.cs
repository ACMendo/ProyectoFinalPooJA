using ProyectoFinalPooJA.Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPooJA.Interfaces
{
    public interface IGenericRepository<T>
    {
        T Crear(T entity);
        List<T> Consultar(int id);
        OperationResult Actualizar(T entity);
        OperationResult Borrar(T entity);
    }
}
