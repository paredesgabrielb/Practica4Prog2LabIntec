using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Prog2LabIntec
{
    class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public override string ToString()
        {
            return $"{IdEmpleado}|{Nombre}|{Salario}";
        }
    }
}
