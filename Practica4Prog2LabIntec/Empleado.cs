using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Configuration.ConfigurationSettings;

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

        public List<Empleado> Empleados => GetNomina();
        private List<Empleado> GetNomina()
        {
            string nominaPath = AppSettings["nominaPath"];
            var nomina = new List<Empleado>();
            if (File.Exists(nominaPath))
            {
                string text = File.ReadAllText(nominaPath);
                foreach (var item in text.Split('\n'))
                {
                    var itemSplit = item.Split('|');
                    nomina.Add(new Empleado()
                    {
                        IdEmpleado = int.Parse(itemSplit[0]),
                        Nombre = itemSplit[1],
                        Salario = double.Parse(itemSplit[2])
                    });
                }

            }
            return nomina;
        }
    }
}
