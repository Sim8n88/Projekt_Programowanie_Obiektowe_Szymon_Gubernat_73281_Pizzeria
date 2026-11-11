using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
  public class Dodatek
    {
        public int Id { get; set; }
        private string _nazwa;
        public string Nazwa
        {
            get
            {
                return _nazwa;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nazwa nie może być pusta ani składać się z samych spacji.");
                }
                else
                {
                    _nazwa = value;
                }
            }
        }
        private decimal _cena;
        public decimal Cena { get
            {
                return _cena;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cena nie może być ujemna");
                }
                else
                {
                    _cena = value;
                }
            }
        }
        public Dodatek(int id,string nazwa,decimal cena)
        {
            Id = id;
            Nazwa = nazwa;
            Cena = cena;
        }
        public override string ToString()
        {
            return $"{Nazwa} ({Cena:F2} zł)";
        }
    }
}
