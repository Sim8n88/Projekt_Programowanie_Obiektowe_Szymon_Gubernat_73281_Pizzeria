using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
   public class StrefaDostawy
    {

        public int Id { get; set; }
        private string _nazwa = string.Empty;
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
                    throw new ArgumentException("Nazwa nie może być pusta");
                }
                else
                {
                    _nazwa = value;
                }
            }
        }
        private decimal _koszt_dowozu;
        public decimal Koszt_Dowozu { 
            get
            {
                return _koszt_dowozu;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Koszt dowozu musi być większy bądź równy zero");
                }
                else
                {
                    _koszt_dowozu = value;
                }
            }
        }
        private decimal _minimalna_kwota;
        public decimal Minimalna_Kwota
        {
            get
            {
                return _minimalna_kwota;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Minimalna kwota musi być większa bądź równa zero");
                }
                else
                {
                    _minimalna_kwota = value;
                }
            }
        }
        public StrefaDostawy(int id,string nazwa,decimal koszt_dowozu,decimal minimalna_kwota)
        {
            Id = id;
            Nazwa = nazwa;
            Koszt_Dowozu = koszt_dowozu;
            Minimalna_Kwota = minimalna_kwota;
        }
        public override string ToString()
        {
            return $"{Nazwa} (dowóz {Koszt_Dowozu:F2} zł, minimalna kwota zamówienia {Minimalna_Kwota:F2})";
        }
    }
}
