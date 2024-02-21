using System.Linq;
using System.Text.RegularExpressions;

namespace Clases
{
    public class ValidadorProductos
    {
        // Validar nombre producto
        public static string IngresarValidarRetornarProducto(short i)
        {
            do
            {
                Console.Write($"Ingresá nombre del producto {i}: ");
                string nombreProducto = Console.ReadLine();
                if (string.IsNullOrEmpty(nombreProducto))
                {
                    Console.WriteLine("Debes ingresar un producto");
                }
                else
                {
                    do
                    {
                        Console.WriteLine($"Ingresaste \"{nombreProducto}\". Esta ok?");
                        Console.Write("Ingresa 's' o 'n': ");
                        string respuesta = Console.ReadLine();
                        if (respuesta.ToLower() == "s")
                        {
                            return nombreProducto;
                        }
                        else if (respuesta.ToLower() == "n")
                        {
                            break;
                        }
                        else if (string.IsNullOrEmpty(nombreProducto))
                        {
                            Console.WriteLine("Opción incorrecta. ");
                        }
                        else
                        {
                            Console.Write("Opción incorrecta. ");
                        }
                    } while (true) ;
                }
            } while (true) ;
        }


        // Validación de precio
        public static decimal IngresarValidarRetornarPrecio()
        {
            do
            {
                Console.Write("Ingresá el precio: ");
                string precioString = Console.ReadLine();
                if (precioString.Contains('.'))
                {
                    precioString = precioString.Replace('.',',');
                }
                if (string.IsNullOrEmpty(precioString))
                {
                    Console.WriteLine("El valor no puede ser vacío");
                }
                else if (decimal.TryParse(precioString, out decimal precio))
                {
                    return precio;
                }
                else
                {
                    Console.WriteLine("Formato incorrecto");
                }
            }while (true);
        }


        // Validación de código del producto
        public static string IngresarValidarRetornarCodigoDeProducto(Dictionary<short, Stack<Producto>> maquinaExpendedora, short j)
        {
            string patron = @"^[A-Z]{2}[0-9]{3}$";
            do
            {
                Console.Write($"Ingresá el código del producto {j}: ");
                string codigoString = Console.ReadLine();
                if (string.IsNullOrEmpty(codigoString))
                {
                    Console.WriteLine("El código no puede ser un valor vacío");
                }
                else if (Regex.IsMatch(codigoString, patron))
                {
                    return codigoString;
                }
                else
                {
                    Console.WriteLine("Formato de código incorrecto");
                }
            } while (true);
        }


        public static short IgresarRetornarCantidadDeUnProducto(string nombre)
        {
            Console.WriteLine($"Cuántos productos {nombre} se cargarán (máx. 10 unidades)?");
            while (true)
            {
                string cantidadString = Console.ReadLine();
                if (string.IsNullOrEmpty(cantidadString))
                {
                    Console.WriteLine("La entrada no puede ser vacía. Debes ingresar un entero entre 1 y 10");
                }
                else if (short.TryParse(cantidadString, out short cantidadDeUnProducto) && cantidadDeUnProducto >=1 && cantidadDeUnProducto <= 10)
                {
                    return cantidadDeUnProducto;
                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta. Debes ingresar un entero entre 1 y 10");
                }
            }
        }
    }
}
