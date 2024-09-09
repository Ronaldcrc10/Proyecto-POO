using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastRent.Models;


public class GerenteDeFlota : Empleado
{
    public GerenteDeFlota(string nombre, int id, double salarioMensual)
    {
        Nombre = nombre;
        ID = id;
        SalarioBruto = salarioMensual;
    }

    public override double CalcularSalarioBruto()
    {
        return SalarioBruto;  // Salario fijo mensual
    }
}


