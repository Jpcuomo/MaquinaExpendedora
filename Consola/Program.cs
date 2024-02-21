using Clases;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int cantidadProductos = 2;
            short posicion;
            Dictionary<short, Stack<Producto>> maquinaExpendedora = new Dictionary<short, Stack<Producto>>();

            maquinaExpendedora = PoblarRetornarExpendedora(maquinaExpendedora, cantidadProductos);

            MostrarProductos(maquinaExpendedora);

            do
            {
                bool continuar = false;
                posicion = SeleccionarProductoPorPosicion(cantidadProductos);
                Console.WriteLine($"Código elegido: {posicion}");
                if (RecibirProductoSeleccionado(posicion, maquinaExpendedora))
                {
                    MostrarProductos(maquinaExpendedora);

                    do
                    {
                        if (maquinaExpendedora.Any(kv => kv.Value.Count() != 0))
                        {
                            Console.Write("Desea retirar otro producto (s/n)?: ");
                            string respuesta = Console.ReadLine();
                            if (respuesta.ToLower() == "n")
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
                        }
                        else
                        {
                            continuar = false;
                            break;
                        }
                    } while (true);

                    if (!continuar)
                    {
                        Console.WriteLine("La expendedora está vacía");
                        break;
                    }
                }
            } while (true);
        }


        //VER//
        public static Dictionary<short, Stack<Producto>> PoblarRetornarExpendedora(Dictionary<short, Stack<Producto>> maquinaExpendedora, short cantidadProductos)
        {
            Console.WriteLine($"Ingresa {cantidadProductos} productos con su precio y código");
            for (short i = 1; i < cantidadProductos + 1; i++)
            {
                Stack<Producto> pilaProducto = new Stack<Producto>();
                string nombre = ValidadorProductos.IngresarValidarRetornarProducto(i); 
                decimal precio = ValidadorProductos.IngresarValidarRetornarPrecio();
                short cantidadDeUnProducto = ValidadorProductos.IgresarRetornarCantidadDeUnProducto(nombre);


                for (short j = 1; j <= cantidadDeUnProducto; j++)
                {
                    string codigoProducto = ValidadorProductos.IngresarValidarRetornarCodigoDeProducto(maquinaExpendedora, j);
                    bool codigoExiste = maquinaExpendedora.Any(kv => kv.Value.Any(p => p.CodigoDeProducto == codigoProducto));

                    if (codigoExiste)
                    {
                        Console.WriteLine("El código ingresado ya existe");
                        j--;
                    }
                    else
                    {
                        Producto producto = new Producto(nombre, precio, codigoProducto);
                        pilaProducto.Push(producto);
                    }
                    maquinaExpendedora[i] = pilaProducto;
                }                
            }
            Console.WriteLine($"Se cargaron los {cantidadProductos} productos con éxito");
            return maquinaExpendedora;
        }


        static void MostrarProductos(Dictionary<short, Stack<Producto>> maquinaExpendedora)
        { 
            HashSet<string> productosImpresos = new HashSet<string>();

            foreach(var kvp in maquinaExpendedora)
            {
                short cantidadDeUnProducto = 0;
                foreach (Producto producto in kvp.Value)
                {
                    cantidadDeUnProducto = (short)kvp.Value.Count();
                    string mensaje = $"- Posición {kvp.Key}: {producto.Nombre} - $ {producto.Precio} - Cantidad de {producto.Nombre}s: {cantidadDeUnProducto}";
                    if (!productosImpresos.Contains(mensaje))
                    {
                        productosImpresos.Add( mensaje );
                    }
                }
            }
            foreach(string mensaje in productosImpresos)
            {
                Console.WriteLine(mensaje);
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


        static bool RecibirProductoSeleccionado(short posicion, Dictionary<short, Stack<Producto>> expendedora)
        {
            if (expendedora.ContainsKey(posicion))
            {
                try
                {
                    Producto producto = expendedora[posicion].Pop();
                    Console.WriteLine(
                        $"Recibiste el producto n°{posicion} " +
                        $"- {producto.Nombre} " +
                        $"- Precio $ {producto.Precio} " +
                        $"- Código: {producto.CodigoDeProducto}");
                    return true;
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"El producto {posicion} no está disponible");
                }
            }     
            return false;
        }  
    }
}
