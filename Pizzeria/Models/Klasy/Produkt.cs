using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
    public abstract class Produkt
    {
        public int Id { get; set; }
        private string _nazwa = string.Empty;
        public string Nazwa
        {
            get { 
                return _nazwa; 
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nazwa nie może być pusta");
                }
                else
                {
                    _nazwa = value;
                }
            }
        }
        private decimal _cena_bazowa;
        public decimal Cena_Bazowa { get
            {
                return _cena_bazowa;
            }
                set{
                if (value < 0)
                {
                    throw new ArgumentException("Cena nie może być ujemna");
                }
                else
                {
                    _cena_bazowa = value;
                }
                }
            }
        public Produkt(int id,string nazwa,decimal cena_bazowa)
        {
            Id = id;
            Nazwa = nazwa;
            Cena_Bazowa = cena_bazowa;

        }
        public abstract decimal ObliczCene();
        public override string ToString()
        {
            return $"{Nazwa} ({ObliczCene()} zł)";
        }
    }
}
