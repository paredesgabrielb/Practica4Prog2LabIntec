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
        //Tu vas a tener un archivo entrada que va a tener el siguiente formato

        //Estudio numero
        //Muestra 1 - dato1, dato2
        //Muestra 2- dato1, dato2, dato3, dato4
        //Muestra 3 - dato

        //Y vas a leer eso con el programa, sacarle la moda mediana varianza etc y printearlo en otro archivo con el formato

        //Estudio numero
        //Muestra 1 - dato1, dato2
        //Moda
        //Mediana
        //Etc
        //Muestra 2- dato1, dato2, dato3, dato4
        //Moda
        //Mediana
        //Etc
        //Muestra 3 - dato

        //Usando listas y clase
        static void Main(string[] args)
        {

            string outPath = AppSettings["outPath"];

            new Ponche();
            new Empleado();

            if (File.Exists(outPath))
            {
                    
            }
            else
            {
                Console.WriteLine("El Archivo Muestras.txt no existe. Favor Verificar");
            }
            Console.Read();
        }


    }
}
