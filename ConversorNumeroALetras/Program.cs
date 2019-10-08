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
            ConvertNumberToString app = new ConvertNumberToString();
            Console.WriteLine(app.ConversorNumberToString(1905040));

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
