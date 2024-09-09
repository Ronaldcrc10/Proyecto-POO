using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastRent.Models
{
    public class AgenteDeAlquiler : Empleado
    {
        public double ComisionEconomico { get; private set; } = 0.10;
        public double ComisionIntermedio { get; private set; } = 0.12;
        public double ComisionLujo { get; private set; } = 0.15;
        private double TotalVentas { get; set; }

        public AgenteDeAlquiler(string nombre, int id)
        {
            Nombre = nombre;
            ID = id;
            TotalVentas = 0;
        }

        public void RegistrarAlquiler(string tipoVehiculo, double montoAlquiler)
        {
            double comision = 0;

            if (tipoVehiculo == "Economico")
                comision = montoAlquiler * ComisionEconomico;
            else if (tipoVehiculo == "Intermedio")
                comision = montoAlquiler * ComisionIntermedio;
            else if (tipoVehiculo == "Lujo")
                comision = montoAlquiler * ComisionLujo;

            TotalVentas += comision;
        }

        public override double CalcularSalarioBruto()
        {
            SalarioBruto = TotalVentas;  // Salario basado en comisiones
            return SalarioBruto;
        }
    }

}
