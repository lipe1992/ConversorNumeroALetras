using ConversorNumeroALetras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConversorNumeroALetras
{
    public class ConvertNumberToString
    {
        Diccionario dic = new Diccionario();
        public string ConversorNumberToString(string num)
        {
            dic.SetDiccionarios();
            int numero = Convert.ToInt32(num);
            if (numero > 0 && numero < 10)
            {
                return GetValueDictionary(numero, dic.Numero0To9);
            }
            else if (numero >= 10 && numero < 20)
            {
                return GetValueDictionary(numero, dic.Numero10To19);
            }
            else
            {
                return GetNumberMayor30(numero.ToString());
            }
        }

        public string GetValueDictionary(int Number, Dictionary<int, string> Dic)
        {
            if (Dic != null && Dic.ContainsKey(Number))
            {
                return Dic[Number];
            }
            return "";
        }

        public string GetNumberMayor30(string numero)
        {
            string salida = "";
            int numeroToInt = 0;
            int numeroToExtra = 0;
            try
            {
                numeroToInt = Convert.ToInt32(numero.Substring(0, 1));
                numeroToExtra = Convert.ToInt32(numero.Substring(1));
            }
            catch (Exception e)
            {
                return "Error : " + numero;
            }

            if (numero.Length == 2)
            {
                salida = ArmarCadenaDecenas(numeroToInt, numeroToExtra);
            }
            else if (numero.Length == 3)
            {
                salida = ArmarCadenaCentenas(numeroToInt, numeroToExtra);
            }
            return salida;
        }

        public string ArmarCadenaDecenas(int numero, int extra)
        {
            string salida = "";
            if(numero == 2)
            {
                salida = ArmarCadena20A29(numero,extra);
            }
            else
            {
                salida = GetValueDictionary(numero, dic.Decenas);
                if (extra != 0)
                {
                    salida += " y " + ConversorNumberToString(extra.ToString());
                }
            }
            return salida;
        }

        public string ArmarCadena20A29(int numero,int extra)
        {
            string salida = "";

            if(extra != 0)
            {
                salida = "Veinti" + ConversorNumberToString(extra.ToString());
            }
            else
            {
                salida = "Veinte";
            }
            return salida;
        }

        public string ArmarCadenaCentenas(int numero, int extra)
        {
            string salida = "";
            salida = GetValueDictionary(numero, dic.Centenas);
            if (extra != 0)
            {
                if (numero == 1)
                {
                    salida += "to ";
                }
                salida += " " + ConversorNumberToString(extra.ToString());
            }
            return salida;
        }
    }
}
