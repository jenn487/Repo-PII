using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_practica2
{
    internal class DocenteContratoFijo : Empleado
    {
        public bool MetaAlcanzada { get; set; }

        public override double CalcularSalario()
        {
            return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
        }
    }
}
