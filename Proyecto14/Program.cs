using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto14
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. CREAR FICHEROS
            //File.Create("D:\\prueba.txt"); // CREAR FICHERO
            //File.Delete("D:\\prueba.txt"); // BORRAR FICHERO -- para ejecutar este bloquear la anterior linea para evitar error

            // 2. CREAR FICHERO
            StreamWriter sw = new StreamWriter("D:\\prueba.txt", true); // escribe la cadena
            for (int i = 0; i < 100; i++)
            {
                sw.WriteLine("Linea: " + i.ToString()); // llenar contenido al archivo o fichero prueba
            }
            sw.Close(); // cerrar
            sw.Dispose(); // disponer

            // 3. LEER FICHERO
            //StreamReader sr = new StreamReader("D:\\prueba.txt"); // mostrar contenido en consola despues de crear
            //while (sr.Peek() >= 0)
            //{
            //    Console.WriteLine(sr.ReadLine());
            //}
            //sr.Close();
            //sr.Dispose();

            //Console.ReadLine();
        }
    }
}
