using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public decimal Precio { get; set; }
        public DateTime Date { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }

    }
}
