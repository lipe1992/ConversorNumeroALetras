using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversorNumeroALetras.Models
{
    public class Diccionario
    {
        public Dictionary<int, string> Numero0To9;//0-9
        public Dictionary<int, string> Numero10To19;//10-19
        public Dictionary<int, string> Numero20To29;//20-29
        public Dictionary<int, string> Decenas;//30-90
        public Dictionary<int, string> Centenas;//100-900

        public void SetDiccionarios()
        {
            SetNumero0To9();
            SetNumero10To19();
            SetNumero20To29();
            SetDecenas();
            SetCentenas();
        }

        public void SetCentenas()
        {
            Centenas = new Dictionary<int, string>();
            Centenas.Add(Constantes.UNO, "Cien");
            Centenas.Add(Constantes.DOS, "Doscientos");
            Centenas.Add(Constantes.TRES, "Trescientos");
            Centenas.Add(Constantes.CUATRO, "Cuatroscientos");
            Centenas.Add(Constantes.CINCO, "Quinientos");
            Centenas.Add(Constantes.SEIS, "Seissientos");
            Centenas.Add(Constantes.SIETE, "Setesientos");
            Centenas.Add(Constantes.OCHO, "Ochoscientos");
            Centenas.Add(Constantes.NUEVE, "Novescientos");

        }
        public void SetDecenas()
        {
            Decenas = new Dictionary<int, string>();
            Decenas.Add(Constantes.TRES, "Treinta");
            Decenas.Add(Constantes.CUATRO, "Cuarenta");
            Decenas.Add(Constantes.CINCO, "Cincuenta");
            Decenas.Add(Constantes.SEIS, "Sesenta");
            Decenas.Add(Constantes.SIETE, "Setenta");
            Decenas.Add(Constantes.OCHO, "Ochenta");
            Decenas.Add(Constantes.NUEVE, "Noventa");
        }
        public void SetNumero0To9()
        {
            Numero0To9 = new Dictionary<int, string>();
            Numero0To9.Add(Constantes.UNO, "Uno");
            Numero0To9.Add(Constantes.DOS, "Dos");
            Numero0To9.Add(Constantes.TRES, "Tres");
            Numero0To9.Add(Constantes.CUATRO, "Cuatro");
            Numero0To9.Add(Constantes.CINCO, "Cinco");
            Numero0To9.Add(Constantes.SEIS, "Seis");
            Numero0To9.Add(Constantes.SIETE, "Siete");
            Numero0To9.Add(Constantes.OCHO, "Ocho");
            Numero0To9.Add(Constantes.NUEVE, "Nueve");
        }
        public void SetNumero10To19()
        {
            Numero10To19 = new Dictionary<int, string>();
            Numero10To19.Add(Constantes.DIEZ, "Diez");
            Numero10To19.Add(Constantes.ONCE, "Once");
            Numero10To19.Add(Constantes.DOCE, "Doce");
            Numero10To19.Add(Constantes.TRECE, "Trece");
            Numero10To19.Add(Constantes.CATORCE, "Catorce");
            Numero10To19.Add(Constantes.QUINCE, "Quince");
            Numero10To19.Add(Constantes.DIECISES, "Dieciseis");
            Numero10To19.Add(Constantes.DIECISIETE, "Diecisiete");
            Numero10To19.Add(Constantes.DIESOCHO, "Diesiocho");
            Numero10To19.Add(Constantes.DIESINUEVE, "Diesinueve");

        }
        public void SetNumero20To29()
        {
            Numero20To29 = new Dictionary<int, string>();
            Numero20To29.Add(20, "Veinte");
            Numero20To29.Add(21, "Veintiuno");
            Numero20To29.Add(22, "Veintidos");
            Numero20To29.Add(23, "Veintitres");
            Numero20To29.Add(24, "Veinticuatro");
            Numero20To29.Add(25, "Veinticinco");
            Numero20To29.Add(26, "Veintiseis");
            Numero20To29.Add(27, "Veintisiete");
            Numero20To29.Add(28, "Veintiocho");
            Numero20To29.Add(29, "Veintinueve");
        }
    }
}
