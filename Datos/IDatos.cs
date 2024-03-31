using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IDatos<T>
    {
        List<T> Listar();
        T leer(string ci);
        T leer(int id);
        void Insertar(T entidad);
        void Actualizar(T entidad);
        bool Eliminar(T entidad);
    }
}
