using ConversorNumeroALetras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversorNumeroALetras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.Log10(245300));
            //ConvertNumberToString app = new ConvertNumberToString();
            //Console.WriteLine(app.ConversorNumberToString(525));
            Conversor conversor = new Conversor();
            Console.WriteLine(conversor.Convertir("7555132243300"));
           /*
            for (int i = 999999; i < 9999999; i++)
            {
                string salida = app.ConversorNumberToString(i);
                if(salida.Contains("Error"))
                {
                    return;
                }
                Console.WriteLine(salida);

            }*/

            Console.ReadKey();
        }
    }
}
