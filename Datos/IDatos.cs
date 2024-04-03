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
        T leerPorId(int id_entidad);
        void Insertar(T entidad);

        void Actualizar(T entidad);
        bool Eliminar(int id_entidad);
    }
}
