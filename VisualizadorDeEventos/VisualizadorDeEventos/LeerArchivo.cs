﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VisualizadorDeEventos
{
    interface leerArchivo
    {
        void leerArchivos();
    }
    internal class LeerArchivo : leerArchivo
    {
        SepararFechaDeEventos fecha1 = new SepararFechaDeEventos();
        public void leerArchivos()
        {
            //Leer archivo
            using (StreamReader leer = new StreamReader(@"C:\Users\vargu\RetoCouch1\eventos.txt"))
            {
                while (!leer.EndOfStream)
                {
                    string fecha = leer.ReadLine();
                    Console.WriteLine("\n" + fecha);

                    fecha1.separarFechaDeEventos(fecha);
                }
            }
        }
    }
}
