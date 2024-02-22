using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public string Nombre { get; }
        public decimal Precio { get; }
        public string CodigoDeProducto { get; }


        private Producto(string codigoDeProducto)
        {
            CodigoDeProducto = codigoDeProducto;
        }

        public Producto(string nombre, decimal precio, string codigoDeProducto) : this(codigoDeProducto)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
