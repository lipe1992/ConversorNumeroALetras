using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversorNumeroALetras.Models
{
    public class Conversor
    {
        public int limite = 4;
        public string Convertir(string numero)
        {
            string salida = "";
            ConvertNumberToString conv = new ConvertNumberToString();

            string numeroNuevo = "";
            string numeroCompleto = "";
            int residuo = numero.Length % 3;
            if(residuo == 2)
            {
                numeroNuevo = numero.Substring(residuo - 1, residuo);
                numeroCompleto = numero.Substring(residuo, numero.Length - 1);      
            }
            else if(residuo == 1)
            {
                numeroNuevo = numero.Substring(residuo - 1, residuo);
                numeroCompleto = numero.Substring(residuo,numero.Length-1);   
            }
            else
            {
                numeroCompleto = numero;
            }
            int contador = 0;
            string cadenaTemp = "";
            List<string> lista = new List<string>();
            List<string> sufijos = new List<string>();
            long log = 0;
            for (int i = 0; i < numeroCompleto.Length; i++)
            {
                
                if (contador == 0)
                {
                    string no = numero.Substring(i);
                    log = (long)Math.Log10(Convert.ToInt64(no));
                }
                
                if (numeroNuevo != "" && i == 0)
                {
                    salida += conv.ConversorNumberToString(numeroNuevo);
                    salida += getSufijo(log);
                }

                cadenaTemp += numeroCompleto[i];
                contador++;
                if (contador == 3)
                {
                    salida += conv.ConversorNumberToString(cadenaTemp);
                    contador = 0;
                    salida += getSufijo(log);
                    cadenaTemp = "";
                }
                else
                {
                    if (i == (numeroCompleto.Length-1))
                    {
                       
                        salida += conv.ConversorNumberToString(cadenaTemp);
                    }
                }
            }
            return salida;
        }

        public string getSufijo(long valor)
        {
            string sufijo = "";
            if (valor > 2 && valor < 6 || valor > 8 && valor < 12)
            {
                sufijo = " Mil ";
            }
            else if (valor > 5 && valor < 9)
            {
                sufijo = " Millones ";
            }
            return sufijo;
        }
    }
}
