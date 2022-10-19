using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Tipo
    {
        List<string>Tipos= new List<string>();
        public Tipo()
        {
            Tipos.Add("Motocicleta");
            Tipos.Add("Automóvil");
            Tipos.Add("Dron");
        }
        public void Tipo_Vehiculo()
        {
            Console.WriteLine("Existen diferentes tipos de vehículos");
        }
        public void ListadoVehiculos()
        {
        }
        public bool Validar(string tipo)
        {
            bool condicion = false;
            foreach (var item in Tipos)
            {
                if (tipo.ToLower()==item.ToLower())
                {
                    condicion = true;
                }               
            }
            return condicion;
        }
        public void Reporte() {
            Console.WriteLine("Tipos De Vehiculos");
            foreach (var item in Tipos)
            {
                Console.WriteLine(item);
            }
        }


    }
}
