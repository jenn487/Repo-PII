using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_practica2
{
    internal class DocentePorHora : Empleado
    {
        public int HorasTrabajadas { get; set; }
        private const double TarifaPorHora = 800;

        public override double CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }
}
