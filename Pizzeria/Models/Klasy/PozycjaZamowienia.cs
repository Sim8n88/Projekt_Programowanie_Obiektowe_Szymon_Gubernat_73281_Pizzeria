using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
    public class PozycjaZamowienia
    {
        public int Id { get; set; }
        private Produkt _produkt = null!;
        public Produkt Produkt
        {
            get
            {
                return _produkt;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Produkt nie może być pusty");
                }
                _produkt = value;
            }
        }
        private int _ilosc;
        public int Ilosc
        {
            get
            {
                return _ilosc;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Ilość musi być równa przynajmniej jeden");
                }
                else
                {
                    _ilosc = value;
                }
            }
        }
        public decimal Cena_Jednostkowa{ get; private set; }
        public PozycjaZamowienia(int id,Produkt produkt,int ilosc)
        {
            Id = id;
            Produkt = produkt;
            Ilosc = ilosc;
            Cena_Jednostkowa = produkt.ObliczCene();
        }
        public decimal Wartosc()
        {
            return Cena_Jednostkowa * Ilosc;
        }
        public override string ToString()
        {
            return $"{Ilosc}x {Produkt.Nazwa} = {Wartosc():F2}";
        }
    }
}
