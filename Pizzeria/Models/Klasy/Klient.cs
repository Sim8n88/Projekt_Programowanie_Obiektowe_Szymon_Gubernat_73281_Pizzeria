using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
    public class Klient:Osoba
    {
        private string _adres=string.Empty;
        public string Adres
        {
            get
            {
                return _adres;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Adres nie może być pusty");
                }
                else
                {
                    _adres=value;
                }
            }
        }
        public bool Staly_Klient { get; set; }
        public Klient(int id,string imie,string nazwisko,string telefon,string adres,bool staly_klient) : base(id, imie, nazwisko, telefon)
        {
            Adres = adres;
            Staly_Klient = staly_klient;
        }
        public override string Rola()
        {
            return "Klient";
        }
        public decimal RabatProcent()
        {
            if (Staly_Klient == true)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
    }
}
