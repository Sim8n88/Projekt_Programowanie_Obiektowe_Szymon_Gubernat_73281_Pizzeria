using System;
using System.Collections.Generic;
using System.Text;
using Pizzeria.Models.Enums;
namespace Pizzeria.Models.Klasy
{
    public class Dostawca:Osoba
    {
        private string _pojazd = string.Empty;
        public string Pojazd
        {
            get
            {
                return _pojazd;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Pojazd nie może być pusty");
                }
                else
                {
                    _pojazd = value;
                }
            }
        }
        public StatusDostawcy Status_Dostawcy { get; set; }= StatusDostawcy.Wolny;
        public int Liczba_Dostaw { get; private set; }
        public Dostawca(int id,string imie,string nazwisko,string telefon,string pojazd) : base(id,imie, nazwisko, telefon)
        {
            Pojazd = pojazd;
        }
        public override string Rola()
        {
            return "Dostawca";
        }
        public void RozpocznijDostawe()
        {
            if (Status_Dostawcy != StatusDostawcy.Wolny)
            {
                throw new InvalidOperationException("Dostawca nie jest wolny");
            }
            else
            {
                Status_Dostawcy = StatusDostawcy.W_Drodze;
            }
        }
        public void ZakonczDostawe()
        {
            if (Status_Dostawcy != StatusDostawcy.W_Drodze)
            {
                throw new InvalidOperationException("Dostawca nie jest w drodze");
            }
            else
            {
                Status_Dostawcy = StatusDostawcy.Wolny;
                Liczba_Dostaw += 1;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, {Pojazd}, {Status_Dostawcy}";
        }
    }
}
