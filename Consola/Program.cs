using Clases;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int cantidadProductos = 3;
            short posicion;
            Dictionary<short, Stack<Producto>> maquinaExpendedora = new Dictionary<short, Stack<Producto>>();

            maquinaExpendedora = PoblarRetornarExpendedora(maquinaExpendedora, cantidadProductos);

            MostrarProductos(maquinaExpendedora);

            do
            {
                bool continuar = false;
                posicion = SeleccionarProductoPorPosicion(cantidadProductos);
                Console.WriteLine($"Código elegido: {posicion}");
                RecibirProductoSeleccionado(posicion, ref maquinaExpendedora);
                MostrarProductos(maquinaExpendedora);
                do
                {
                    Console.WriteLine("Desea retirar otro producto (s/n)?: ");
                    string respuesta = Console.ReadLine();
                    if ( respuesta.ToLower() == "n")
                    {
                        Console.WriteLine("Gracias por usar nuestro servicio. Vuelva prontos!");
                        break;
                    }
                    else if (respuesta.ToLower() == "s")
                    {
                        continuar = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Respuesta incorrecta");
                    }

                } while (true);

                if (!continuar)
                {
                    break;
                }

            if (maquinaExpendedora.Count() == 0)
            {
                Console.WriteLine("La expendedora está vacía");
                break;
            }
            } while (maquinaExpendedora.Count() < cantidadProductos);
        }


        public static Producto CrearObjetoProducto(short posicion, Dictionary<short, Stack<Producto>> maquinaExpendedora)
        {
            // Inicializo atributos de producto
            string nombre = ValidadorProductos.IngresarValidarRetornarProducto(posicion);
            decimal precio = ValidadorProductos.IngresarValidarRetornarPrecio();
            string codigoProducto = ValidadorProductos.IngresarValidarRetornarCodigoDeProducto(maquinaExpendedora);
                
            // Creo instancia de Producto
            return new Producto(nombre, precio, codigoProducto);
        }

        //VER//
        //public static Dictionary<short, Stack<Producto>> PoblarRetornarExpendedora(Dictionary<short, Stack<Producto>> maquinaExpendedora, short cantidadProductos)
        //{
        //    Console.WriteLine($"Ingresa {cantidadProductos} productos con su precio y código");
        //    for (short i = 1; i < cantidadProductos + 1; i++)
        //    {


        //        Stack<Producto> pilaProducto = new Stack<Producto>();
        //        pilaProducto.Push(producto);
        //        maquinaExpendedora[i] = pilaProducto;
        //        //break;
        //    }
        //    Console.WriteLine($"Se cargaron los {cantidadProductos} productos con éxito");
        //    return maquinaExpendedora;
        //}


        static void MostrarProductos(Dictionary<short, Stack<Producto>> maquinaExpendedora)
        {
            foreach(var kvp in maquinaExpendedora)
            {
                foreach(Producto producto in kvp.Value)
                {
                    Console.WriteLine($"- Posición {kvp.Key}: {producto.Nombre} - $ {producto.Precio} - Código: {producto.CodigoDeProducto}");
                }
            }
        }


        static short SeleccionarProductoPorPosicion(int cantidadProductos)
        {
            do
            {
                Console.Write($"Ingresá la posición del producto que queres (1 al {cantidadProductos}): ");
                string posicionTxt = Console.ReadLine();
                if (string.IsNullOrEmpty(posicionTxt))
                {
                    Console.WriteLine("La posición no puede ser vacía");
                }
                else if (short.TryParse(posicionTxt, out short posicion) && posicion >= 1 && posicion <= 12)
                {
                    return posicion;
                }
                else
                {
                    Console.WriteLine("Posición incorrecta");
                }
            } while (true);
        }


        static bool RecibirProductoSeleccionado(short posicion, ref Dictionary<short, Stack<Producto>> expendedora)
        {
            foreach (Stack<Producto> stack in expendedora.Values)
            {
                foreach (Producto producto in stack)
                {
                    Console.WriteLine($"Recibiste el producto n°{posicion} - {producto.Nombre} - Precio $ {producto.Precio}");
                    expendedora.Remove(posicion);
                    return true;
                }
            }
            Console.WriteLine($"El producto {posicion} no está disponible");
            return false;
        }  
    }
}
