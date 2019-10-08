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

        public string ConversorNumberToString(int numero)
        {
            dic.SetDiccionarios();
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
            else if(numero.Length == 4){
                salida = ArmarUnidadMillar(numeroToInt,numeroToExtra);
            }
            else if (numero.Length == 5)
            {
                numeroToInt = Convert.ToInt32(numero.Substring(0, 2));
                numeroToExtra = Convert.ToInt32(numero.Substring(2));
                salida = ArmarUnidadMillar(numeroToInt, numeroToExtra);
            }
            else if(numero.Length == 6)
            {
                numeroToInt = Convert.ToInt32(numero.Substring(0, 3));
                numeroToExtra = Convert.ToInt32(numero.Substring(3));
                salida = ArmarCentenMillar(numeroToInt, numeroToExtra);
            }
            else if (numero.Length == 7)
            {
                salida = ArmarMillones(numeroToInt,numeroToExtra);
            }

            return salida;
        }
        public string ArmarMillones(int numero,int extra)
        {
            string salida = ""; 
            if(numero == 1)
            {
                salida = "Un Millon ";
            }
            else
            {
                salida = GetValueDictionary(numero,dic.Numero0To9) + " Millones "; 
            }

            if(extra != 0)
            {
                salida += ConversorNumberToString(extra);
            }
            
            return salida;

        }
        public string ArmarCentenMillar(int numero,int extra)
        {
            string salida = "";
            salida = ConversorNumberToString(numero) + " Mil ";
            if (extra != 0)
            {
                 salida +=  ConversorNumberToString(extra);
            }
            return salida;
        }

        public string ArmarUnidadMillar(int numero,int extra)
        {
            string salida = "";
            if(numero == 1)
            {
                salida = "Mil";
                if(extra != 0)
                {
                    salida += ConversorNumberToString(extra);
                }
                
            }
            else
            {
                if (numero >= 10 && numero < 20)
                {
                    salida = GetValueDictionary(numero, dic.Numero10To19) + " Mil ";
                }
                else if(numero >= 20 && numero < 30)
                {
                    string temp = GetValueDictionary(numero, dic.Numero20To29);
                    if (numero == 21)
                    {
                        salida = temp.Substring(0, temp.Length - 1);
                    }
                    else
                    {
                        salida = temp;
                    }
                    
                    salida +=" Mil ";
                }
                else
                {
                    salida = GetValueDictionary(numero, dic.Numero0To9) + " Mil ";
                    
                }

                if (extra != 0)
                {
                    salida += ConversorNumberToString(extra);
                }
                
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
                    salida += " y " + ConversorNumberToString(extra);
                }
            }
            

            return salida;
        }

        public string ArmarCadena20A29(int numero,int extra)
        {
            string salida = "";

            if(extra != 0)
            {
                salida = "Veinti" + ConversorNumberToString(extra);
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
                salida += " " + ConversorNumberToString(extra);
            }
            return salida;
        }
    }
}
