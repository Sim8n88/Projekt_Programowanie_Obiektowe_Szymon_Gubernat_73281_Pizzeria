using Pizzeria.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models.Klasy
{
    public class Pizza:Produkt
    {
        public RozmiarPizzy Rozmiar { get; set; }
        public Pizza(int id, string nazwa, decimal cena_bazowa,RozmiarPizzy rozmiar) : base(id, nazwa, cena_bazowa)
        {
            Rozmiar = rozmiar;
        }
        private List<Dodatek> _dodatki = new List<Dodatek>();
        public void DodajDodatek(Dodatek dodatek)
        {
            if (dodatek == null)
            {
                throw new ArgumentNullException(nameof(dodatek));
            }
         
            if (_dodatki.Count >= 5)
            {
                throw new InvalidOperationException("Maksymalnie pięć dodatków");
            }
            _dodatki.Add(dodatek);

        }
        public void UsunDodatek(Dodatek dodatek)
        {

            if (dodatek == null)
            {
                throw new ArgumentNullException(nameof(dodatek));
            }
            _dodatki.Remove(dodatek);
        }
        public override decimal ObliczCene()
        {
            decimal cena;
            switch (Rozmiar)
            {
               
                case RozmiarPizzy.Duza:
                    cena =Cena_Bazowa * 1.6M;
                    break;
                case RozmiarPizzy.Srednia:
                    cena= Cena_Bazowa * 1.3M;
                    break;
                case RozmiarPizzy.Mala:
                    cena= Cena_Bazowa;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Rozmiar), "Nieznany rozmiar pizzy");
            }
            foreach(Dodatek dodatek in _dodatki)
            {
                cena += dodatek.Cena;
            }
            return cena;
            
        }

    }
}
