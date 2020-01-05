using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_z1
{
    interface ICepikData { }
    interface IStatData { }
    interface IPoliceData { }
    class Program : ICepikData
    {
        class Auto
        {
            //vehicle
            public string typ_pojazdu;
            public string marka;
            public float pojemnosc;
            public int liczba_miejsc;
            public string VIN;
            public string nr_rejestracyjny;
            public string rok_produkcji;
            public string kolor;
            public string polisa_nr;
            //owner
            public string imie_i_nazwisko;
            public string adres_zamieszkania;
            public string pesel;
            public string nr_prawa_jazdy;
            public string data_uzysk_prawa_jazdy;
            public string rok_zakupu;
            public string liczba_pkt_karnych;
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Cwiczenie1");
            }
    }
}
