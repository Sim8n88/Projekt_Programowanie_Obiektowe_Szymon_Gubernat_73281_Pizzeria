using Pizzeria.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
    public class ZamowienieZDostawa : Zamowienie
    {
        private string _adres_dostawy = string.Empty;
        public string Adres_Dostawy
        {
            get
            {
                return _adres_dostawy;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Adres nie może być pusty");
                }
                else
                {
                    _adres_dostawy = value;
                }
            }
        }
        private StrefaDostawy _strefa = null!;
        public StrefaDostawy Strefa
        {
            get
            {
                return _strefa;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Strefa nie może być pusta");
                }
                else
                {
                    _strefa = value;
                }
            }
        }
        public Dostawca? Dostawca { get; set; }
        public ZamowienieZDostawa(int id,Klient klient,string adres_dostawy,StrefaDostawy strefa) : base(id, klient)
        {
            Adres_Dostawy = adres_dostawy;
            Strefa = strefa;
        }
        public override decimal KosztDostawy()
        {
            return Strefa.Koszt_Dowozu;
        }
        public void PrzydzielDostawce(Dostawca dostawca)
        {
            if (dostawca == null)
            {
                throw new ArgumentNullException(nameof(dostawca), "Dostawca nie może być pusty");
            }
            if (Status != StatusZamowienia.Gotowe)
            {
                throw new InvalidOperationException("Dostawcę można przydzielić tylko do zamówienia ze statusem 'Gotowe'");
            }
            if (SumaPozycji() < Strefa.Minimalna_Kwota)
            {
                throw new InvalidOperationException($"Zamówienie nie osiąga minimalnej kwoty strefy ({Strefa.Minimalna_Kwota:F2} zł)");
            }

            dostawca.RozpocznijDostawe();
            Dostawca = dostawca;
            ZmienStatus(StatusZamowienia.W_Dostawie);
        }

        public override string ToString()
        {
            return $"Zamówienie z dostawą nr {Id}, {Klient.Imie} {Klient.Nazwisko}, {Adres_Dostawy} ({Strefa.Nazwa}), razem {CalkowitaCena():F2} zł";
        }
    }
}
