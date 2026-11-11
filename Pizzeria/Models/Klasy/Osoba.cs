using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
    public abstract class Osoba
    {
        public int Id { get; set; }
        private string _imie = string.Empty;
        public string Imie
        {
            get
            {
                return _imie;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Imie nie może być puste");
                }
                else
                {
                    _imie = value;
                }
            }
        }
        private string _nazwisko = string.Empty;
        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nazwisko nie może być puste");
                }
                else
                {
                    _nazwisko = value;
                }
            }
        }
        private string _telefon = string.Empty;
        public string Telefon { get
            {
                return _telefon;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Telefon nie może być pusty");
                }
                if (value.Length != 9)
                {
                    throw new ArgumentException("Telefon musi mieć 9 cyfr");
                }
                bool flaga = true;
                foreach (char cyfra in value)
                {
                    if (char.IsDigit(cyfra))
                    {

                    }
                    else
                    {
                        flaga = false;
                    }
                }
                if (flaga == false)
                {
                    throw new ArgumentException("Telefon musi składać się wyłącznie z cyfr");
                }
                _telefon = value;

            }

        }
        public Osoba(int id, string imie, string nazwisko, string telefon)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Telefon = telefon;
        }
        public abstract string Rola();
        public override string ToString()
        {
            return $"{Imie} {Nazwisko} ({Rola()})";
        }
            
        
    }
}
