using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Prog2LabIntec
{
    class Resultado
    {
        public Empleado Empleado { get; set; }
        public List<PoncheDiario> Ponches { get; set; }

        public int HorasTrabajadas => Ponches.Sum(x=>x.HorasTrabajadas);
        public double SalarioTotal => Ponches.Sum(x => x.SalarioDia);

        public override string ToString()
        {
            return $"{Empleado.IdEmpleado}|{HorasTrabajadas}|{Empleado.Salario}|{SalarioTotal}";
        }
    }
}
