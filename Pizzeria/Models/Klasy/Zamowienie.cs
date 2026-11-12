using Pizzeria.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
    public abstract class Zamowienie
    {
        public int Id { get; set; }
        private Klient _klient = null!;
        public Klient Klient
        {
            get
            {
                return _klient;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Klient nie może być pusty");
                }
                else
                {
                    _klient = value;
                }
            }
        }
        public StatusZamowienia Status { get; private set; } = StatusZamowienia.Przyjete;
        public DateTime Data_Zlozenia { get; private set; } = DateTime.Now;
        public Zamowienie(int id, Klient klient){
            Id = id;
            Klient = klient;
            }
        private List<PozycjaZamowienia> _pozycje = new List<PozycjaZamowienia>();
        public void DodajPozycje(PozycjaZamowienia pozycja)
        {
            if (pozycja == null)
            {
                throw new ArgumentNullException(nameof(pozycja), "Pozycja nie może być pusta");
            }
            if (Status != StatusZamowienia.Przyjete)
            {
                throw new InvalidOperationException("Status zamówienia musi być oznaczony 'Przyjęte'");
            }
             _pozycje.Add(pozycja);
            
        }
        public void UsunPozycje(PozycjaZamowienia pozycja)
        {
            if (pozycja == null)
            {
                throw new ArgumentNullException(nameof(pozycja), "Pozycja nie może być pusta");
            }
            if (Status != StatusZamowienia.Przyjete)
            {
                throw new InvalidOperationException("Status zamówienia musi być oznaczony 'Przyjęte'");
            }
            _pozycje.Remove(pozycja);
        }
        public IReadOnlyList<PozycjaZamowienia> Pozycje { get { return _pozycje; } }

   
        public decimal SumaPozycji()
        {
            decimal suma = 0;
            foreach (PozycjaZamowienia pozycja in _pozycje)
            {
                suma += pozycja.Wartosc();
            }
            return suma;
        }
        public abstract decimal KosztDostawy();
        public decimal CalkowitaCena()
        {
            return SumaPozycji() - (SumaPozycji()* Klient.RabatProcent()/100) + KosztDostawy();
        }
        public void ZmienStatus(StatusZamowienia nowyStatus)
        {
            bool dozwolone;

            switch (Status)
            {
                case StatusZamowienia.Przyjete:
                    dozwolone = nowyStatus == StatusZamowienia.W_Przygotowaniu || nowyStatus == StatusZamowienia.Anulowane;
                    break;
                case StatusZamowienia.W_Przygotowaniu:
                    dozwolone = nowyStatus == StatusZamowienia.Gotowe || nowyStatus == StatusZamowienia.Anulowane;
                    break;
                case StatusZamowienia.Gotowe:
                    dozwolone = nowyStatus == StatusZamowienia.W_Dostawie;
                    break;
                case StatusZamowienia.W_Dostawie:
                    dozwolone = nowyStatus == StatusZamowienia.Zrealizowane;
                    break;
                default:
                    dozwolone = false;
                    break;
            }

            if (!dozwolone)
            {
                throw new InvalidOperationException($"Niedozwolona zmiana statusu z {Status} na {nowyStatus}");
            }

            Status = nowyStatus;
        }
    }
}
