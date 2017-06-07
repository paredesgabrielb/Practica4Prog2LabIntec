using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4Prog2LabIntec
{
    class Ponche
    {
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }

        public Tipo Tipo { get; set; }

        public override string ToString()
        {
            return $"{IdEmpleado}|{Fecha:YYYY/MM/DD HH.MM}|{Tipo}";
        }
    }

    public enum Tipo { Entrada, Salida };


}
