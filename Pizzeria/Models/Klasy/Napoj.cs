using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
    public class Napoj:Produkt
    {
        private int _pojemnosc_ml;
        public int Pojemnosc_Ml { get
            {
                return _pojemnosc_ml;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Pojemność musi być większa od 0");
                }
                else
                {
                    _pojemnosc_ml = value;
                }
            }
                }
        public Napoj(int id,string nazwa,decimal cena_bazowa,int pojemnosc_ml) : base(id, nazwa, cena_bazowa)
        {
            Pojemnosc_Ml = pojemnosc_ml;
        }
        public override decimal ObliczCene()
        {
            return Cena_Bazowa;
        }
        public override string ToString()
        {
            return $"{Nazwa} o pojemności {Pojemnosc_Ml} ml kosztuje {ObliczCene():F2} zł";
        }
    }
}
