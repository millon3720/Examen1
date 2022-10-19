using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vendedores
    {

        Dictionary<int, string> Vendedores1 = new Dictionary<int, string>();   
        
        public Vendedores()
        {
            Vendedores1.Add(1, "Vendedor 2");
            Vendedores1.Add(2, "Vendedor 2");
        }
        public string ListadoVendedores(string Codigo)
        {
            foreach (var item in Vendedores1)
            {
                if (item.Key.ToString() == Codigo)
                {
                    return item.Value;
                }                
            }
            return "";
        }
        public string VerificarVendedor(string Codigo)
            {
            string nombre = ListadoVendedores(Codigo);
            if (nombre!="")
            {
                return "El Nombre Del vendedor Es "+nombre;
            }
            return "El Codigo Digitado no existe";
        }
        public void Reporte()
        {
            Console.WriteLine("Reporte De Vendedores");
            foreach (var item in Vendedores1)
            {
                Console.WriteLine("Codigo {0} Nombre{1}",item.Key,item.Value);
            }
        }
    }
}
