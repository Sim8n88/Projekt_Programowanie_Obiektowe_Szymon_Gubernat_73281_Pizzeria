using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
    public class ZamowienieNaWynos:Zamowienie
    {
        private DateTime _godzina_odbioru;
        public DateTime Godzina_Odbioru
        {
            get
            {
                return _godzina_odbioru;
            }
            set
            {
                if (value < Data_Zlozenia)
                {
                    throw new ArgumentException("Godzina odbioru nie może być wcześniejsza niż data złożenia zamówienia");
                }
                else
                {
                    _godzina_odbioru = value;
                }
            }
        }
        public ZamowienieNaWynos(int id,Klient klient,DateTime godzina_odbioru) : base(id, klient)
        {
            Godzina_Odbioru = godzina_odbioru;
        }
        public override decimal KosztDostawy()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"Zamówienie na wynos nr {Id}, {Klient.Imie} {Klient.Nazwisko}, odbiór {Godzina_Odbioru:HH:mm}, razem {CalkowitaCena():F2}";
        }
    }
}
