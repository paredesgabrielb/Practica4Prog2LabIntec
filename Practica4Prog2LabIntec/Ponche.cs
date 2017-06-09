using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Configuration.ConfigurationSettings;

namespace Practica4Prog2LabIntec
{
    class Ponche
    {
        public Ponche()
        {
            Ponches = GetPonches();
        }
        public Empleado Empleado { get; set; }
        public DateTime Fecha { get; set; }

        public Tipo Tipo { get; set; }

        public override string ToString()
        {
            return $"{Empleado.IdEmpleado}|{Fecha:YYYY/MM/DD HH.MM}|{Tipo}";
        }

        public static List<Ponche> Ponches { get; set; }
        private  List<Ponche> GetPonches()
        {
            string ponchePath = AppSettings["ponchePath"];
            var ponches = new List<Ponche>();
            if (File.Exists(ponchePath))
            {
                string text = File.ReadAllText(ponchePath);
                foreach (var item in text.Split('\n'))
                {
                    var itemSplit = item.Split('|');
                    ponches.Add(new Ponche()
                    {
                        Empleado = Empleado.Empleados.FirstOrDefault(x=> x.IdEmpleado == int.Parse(itemSplit[0])), 
                        Fecha = DateTime.Parse(itemSplit[1]),
                        Tipo = itemSplit[2] == "e" ? Tipo.Entrada : Tipo.Salida
                    });
                }

            }
            return ponches;
        }
    }

    public enum Tipo { Entrada, Salida };

    class PoncheDiario
    {
        public Empleado Empleado => Entrada.Empleado;
        public Ponche Entrada { get; set; }
        public Ponche Salida { get; set; }
        public int HorasTrabajadas => (Salida.Fecha.Minute - Entrada.Fecha.Minute) / 60;
        public double SalarioDia => Empleado.Salario * HorasTrabajadas;

        public static List<PoncheDiario> PonchesDiarios(List<Ponche> ponches)
        {
            var cant = ponches.GroupBy(p => p.Empleado.IdEmpleado).Select(g => g.First()).ToList().Count;
            var cant2 = ponches.GroupBy(p => p.Empleado).Select(g => g.First()).ToList().Count;
            var result = new List<PoncheDiario>();
            foreach (var item in ponches.GroupBy(p => new {p.Empleado,p.Fecha.Date }).Select(g => g.First()).ToList())
            {
                
            }

            return result;
        }
    }

}
