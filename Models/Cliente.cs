using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastRent.Models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public string TipoVehiculo { get; set; }
        public int DiasAlquiler { get; set; }
        public double CostoTotal { get; set; }

        public Cliente(string nombre, int id, string tipoVehiculo, int diasAlquiler)
        {
            Nombre = nombre;
            ID = id;
            TipoVehiculo = tipoVehiculo;
            DiasAlquiler = diasAlquiler;
            CostoTotal = CalcularCostoAlquiler();
        }

        public double CalcularCostoAlquiler()
        {
            double costoDiario = 0;

            switch (TipoVehiculo)
            {
                case "Economico":
                    costoDiario = 200000;
                    break;
                case "Intermedio":
                    costoDiario = 350000;
                    break;
                case "Lujo":
                    costoDiario = 600000;
                    break;
            }

            return costoDiario * DiasAlquiler;
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Cliente: {Nombre}, ID: {ID}, Tipo de Vehículo: {TipoVehiculo}, Días: {DiasAlquiler}, Costo Total: {CostoTotal}");
        }
    }
}
