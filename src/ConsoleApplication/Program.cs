//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;
using static System.Linq.Enumerable;


namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
       
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            foreach (var index in Range(1, 30000))
            {
               // Console.WriteLine(index);
                var train = new Train("lala");
                train.StartEngines();
                //int contador=train.Count;
                Console.WriteLine($"{train.Count}");
            //  Console.WriteLine("Hello World!");
            }
                var t1 = new Train("Last Train To London");
                var t2 = new Train("Last Train To London");
                var t3 = new Train("Runaway Train");
                Console.WriteLine($"¿Los dos Trenes t1 y t2 apuntan al mismo objeto? {t1 == t2}");
                Console.WriteLine($"¿Los dos Trenes t2 y t3 apuntan al mismo objeto? {t2 == t3}");
        }
    }
}