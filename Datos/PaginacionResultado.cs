using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PaginacionResultado<T>
    {
        public List<T> Items { get; set; }
        public int TotalRegistros { get; set; }
    }
}
