using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Configuration.ConfigurationSettings;

namespace Practica4Prog2LabIntec
{
    class Program
    {

        static void Main(string[] args)
        {

            string outPath = AppSettings["outPath"];


            var ponches = Ponche.GetPonches();
            var ponchesDiarios = PoncheDiario.PonchesDiarios(ponches);
            var empleado = new Empleado();
            var resultado = new List<Resultado>();

            foreach (var emp in empleado.Empleados)
            {
                resultado.Add(new Resultado()
                {
                    Empleado = emp,
                    Ponches = ponchesDiarios.Where(x => x.Empleado.IdEmpleado == emp.IdEmpleado).ToList()
                });
            }
            if (File.Exists(outPath))
            {
                try
                {
                    using (StreamWriter file = new StreamWriter(outPath, true))
                    {
                        
                        foreach (var item in resultado)
                        {
                            file.WriteLine(item.ToString());
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                Console.WriteLine("El proceso finalizo Correctamente");
            }
            else
            {
                Console.WriteLine("El Archivo Muestras.txt no existe. Favor Verificar");
            }
            Console.WriteLine("\n\nPresione una tecla para salir");
            Console.ReadLine();
        }


    }
}
