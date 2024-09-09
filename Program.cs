using FastRent.Models;

namespace FastRent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un Gerente de Flota
            GerenteDeFlota gerente = new GerenteDeFlota("Carlos García", 101, 5000000);
            Console.WriteLine($"Gerente: {gerente.Nombre}, Salario Neto: {gerente.CalcularSalarioNeto()}");

            // Crear un Agente de Alquiler
            AgenteDeAlquiler agente = new AgenteDeAlquiler("María López", 202);
            agente.RegistrarAlquiler("Economico", 200000 * 5);  // Alquiler de 5 días para vehículo económico
            agente.RegistrarAlquiler("Lujo", 600000 * 2);       // Alquiler de 2 días para vehículo de lujo

            // Calcular salario bruto antes de mostrar el salario neto
            double salarioNetoAgente = agente.CalcularSalarioNeto();
            Console.WriteLine($"Agente: {agente.Nombre}, Salario Neto: {salarioNetoAgente}");

            // Registrar un alquiler de cliente
            Cliente cliente = new Cliente("Juan Pérez", 301, "Intermedio", 4);
            cliente.MostrarResumen();
        }
    }
}
