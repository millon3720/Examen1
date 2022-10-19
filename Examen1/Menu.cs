    using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen1.Clases
{
    public static class Menu
    {
        public static void MenuUsuario()
        {
            Vendedores vendedores = new Vendedores();
            Tipo tipo = new Tipo();
            Vehiculos vehiculos = new Vehiculos();
            bool Validar = true;
            string Opcion = "";
            do
            {
                Console.WriteLine("Seleccione la Opcion Deseada " +
                    "a-Vehículos b-Ventas c-Reportes d- Salir");
                Opcion = Console.ReadLine().ToLower();
                switch (Opcion)
                {
                    case "a":
                        Console.WriteLine("Seleccione la Opcion Deseada " +
                    "a-Agregar b-Modificar  c-consultar d- Salir");
                        Opcion = Console.ReadLine().ToLower();
                        switch (Opcion) {
                            case "a":
                                Console.WriteLine("Digite el codigo del vehiculo ");
                                vehiculos.Codigo1 = Console.ReadLine();
                                Console.WriteLine("Digite la marca del vehiculo ");
                                vehiculos.Marca1 = Console.ReadLine();
                                Console.WriteLine("Digite el costo del vehiculo ");
                                vehiculos.Costo1 = Console.ReadLine();
                                Console.WriteLine("Digite el modelo del vehiculo ");
                                vehiculos.Modelo1 = Console.ReadLine();
                                vehiculos.AgregarVehiculo();
                                break;
                            case "b":
                                Console.WriteLine("Digite el codigo del vehiculo ");
                                vehiculos.Codigo1 = Console.ReadLine();
                                Console.WriteLine("Digite la marca del vehiculo ");
                                vehiculos.Marca1 = Console.ReadLine();
                                Console.WriteLine("Digite el costo del vehiculo ");
                                vehiculos.Costo1 = Console.ReadLine();
                                Console.WriteLine("Digite el modelo del vehiculo ");
                                vehiculos.Modelo1 = Console.ReadLine();
                                vehiculos.ModificarVehiculo();
                                break;
                            case "c":
                                vehiculos.ConsultarArticulos();
                                break;
                            case "d":

                                break;
                        }
                        break;
                    case "b":
                        Console.WriteLine("Digite El Codigo Del Vehiculo");
                        vehiculos.Codigo1 = Console.ReadLine().ToLower();
                        vehiculos.ConsultarArticulos();
                        Console.WriteLine("Digite la categoria");
                        tipo.Validar(Console.ReadLine().ToLower());
                        Console.WriteLine("Digite El Codigo Del Vendedor");
                        vendedores.VerificarVendedor(Console.ReadLine().ToLower());
                        Console.WriteLine("El total a pagar por el vehiculo marca {0} es de {1} ",vehiculos.Marca1,vehiculos.Costo1);
                        break;
                    case "c":
                        vendedores.Reporte();
                        tipo.Reporte();
                        vehiculos.Reporte();
                        break;
                    case "d":
                        Validar = false;
                        break;
                }
            } while (Validar);        
        }
    }
}
