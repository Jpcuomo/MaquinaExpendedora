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
        public string CodigoDeProducto { get; set; }


        public Producto(string nombre, decimal precio, string codigoDeProducto)
        {
            Nombre = nombre;
            Precio = precio;
            CodigoDeProducto = codigoDeProducto;
        }
    }
}
