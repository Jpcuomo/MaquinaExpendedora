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
        public static string IngresarValidarRetornarCodigoDeProducto(Dictionary<short, Stack<Producto>> maquinaExpendedora)
        {
            string patron = @"^[A-Z]{2}[0-9]{3}$";
            do
            {
                bool codigoExiste = false;
                Console.Write("Ingresá el código del producto: ");
                string codigoString = Console.ReadLine();
                if (string.IsNullOrEmpty(codigoString))
                {
                    Console.WriteLine("El código no puede ser un valor vacío");
                    continue;
                }
                else if(Regex.IsMatch(codigoString, patron))
                {
                    //if(maquinaExpendedora.Any(kv => kv.Value.Any(producto => producto.CodigoDeProducto == codigoString))
                    foreach(Stack<Producto> stack in maquinaExpendedora.Values)
                    {
                        foreach(Producto p in stack)
                            {
                                if(p.CodigoDeProducto == codigoString)
                                {
                                    Console.WriteLine("El código ingresado ya existe");
                                    codigoExiste = true;
                                    break;
                                }
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Formato de código incorrecto");
                    continue;
                }
                if (!codigoExiste)
                {
                    return codigoString;
                }
            } while (true);
        }
    }
}
