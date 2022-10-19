using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Vehiculos
    {
        private string[] Codigo= new string[5], Marca = new string[5],
            Costo = new string[5], Modelo = new string[5];
        private string codigo, marca, costo, modelo;

        public string Codigo1 { get => codigo; set => codigo = value; }
        public string Marca1 { get => marca; set => marca = value; }
        public string Costo1 { get => costo; set => costo = value; }
        public string Modelo1 { get => modelo; set => modelo = value; }

        public Vehiculos()
        { 
        
        }
        public Vehiculos(string codigo, string marca, string costo, string modelo)
        {
            this.Codigo1 = codigo;
            this.Marca1= marca;
            this.Costo1 = costo;
            this.Modelo1 = modelo;
        }
             
        public void AgregarVehiculo()
        {
            bool Condicion = true;
            byte i = 0;
            do
            {
                if (Codigo[i] == null)
                {
                    Condicion = true;
                }
                i++;
            } while (i<5);
            if (Condicion)
            {
                Codigo[i] = Codigo1;
                Marca[i]= Marca1;
                Costo[i] = Costo1;
                Modelo[i] = Modelo1;
            }
            else
            {
                Console.WriteLine("No Es Posible guardar un nuevo vehiculo");
            }
        }
        public void ModificarVehiculo() {
            byte i = 0;
            do
            {
                if (Codigo[i] == Codigo1)
                {
                    Codigo[i] = Codigo1;
                    Marca[i] = Marca1;
                    Costo[i] = Costo1;
                    Modelo[i] = Modelo1;
                }
                i++;
            } while (i < 5);
        }
        public string ConsultarArticulos()
        {
            byte i = 0;
            do
            {
                if (Codigo[i] == Codigo1)
                {
                    Codigo1=Codigo[i];
                    Marca1=Marca[i];
                    Costo1=Costo[i];
                    Modelo1=Modelo[i];
                    return "Codigo"+ Codigo[i]+" Marca"+ Marca[i] +"Costo "+Costo[i] +"Modelo"+ Modelo[i];
                }
                i++;
            } while (i < 5);
            return "Vehiculo no encontrado";
        }
        public void Reporte() {
            Console.WriteLine("Vehiculos ingresados");
            for (int i = 0; i < Codigo.Length; i++)
            {
                Console.WriteLine(Codigo[i],Marca[i],Costo[i],Modelo[i]);
            }
        }

    }
}
