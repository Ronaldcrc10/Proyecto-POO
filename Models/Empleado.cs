using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastRent.Models
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        protected double SalarioBruto { get; set; }

        // Métodos abstractos para calcular salario y deducciones
        public abstract double CalcularSalarioBruto();

        public double CalcularDeducciones()
        {
            double seguroVida = SalarioBruto * 0.05;
            double fondoJubilacion = SalarioBruto * 0.03;
            return seguroVida + fondoJubilacion;
        }

        public double CalcularSalarioNeto()
        {
            return CalcularSalarioBruto() - CalcularDeducciones();
        }
    }

}
