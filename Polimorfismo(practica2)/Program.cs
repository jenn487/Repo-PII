using System;
using System.Collections.Generic;

namespace Polimorfismo_practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

           
            DocentePorHora docente1 = new DocentePorHora
            {
                Nombre = "Jennifer D1",
                HorasTrabajadas = 40
            };
            empleados.Add(docente1);

            
            DocenteContratoFijo docente2 = new DocenteContratoFijo
            {
                Nombre = "Jennifer D2",
                SalarioBase = 2000,
                MetaAlcanzada = true
            };
            empleados.Add(docente2);

           
            EmpleadoAdministrativo administrativo1 = new EmpleadoAdministrativo
            {
                Nombre = "Jennifer Admin",
                SalarioBase = 1500,
                MetaAlcanzada = false
            };
            empleados.Add(administrativo1);

            
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Nombre: {empleado.Nombre}, Salario: {empleado.CalcularSalario()}");
            }

            Console.ReadLine();
        }
    }
}
