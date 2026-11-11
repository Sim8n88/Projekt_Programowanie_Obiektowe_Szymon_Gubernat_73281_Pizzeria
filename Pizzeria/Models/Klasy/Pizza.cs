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
        public override decimal ObliczCene()
        {
            switch (Rozmiar)
            {
                case RozmiarPizzy.Duza:
                    return Cena_Bazowa * 1.6M;
                case RozmiarPizzy.Srednia:
                    return Cena_Bazowa * 1.3M;
                case RozmiarPizzy.Mala:
                    return Cena_Bazowa;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Rozmiar), "Nieznany rozmiar pizzy");
            }
            
        }

    }
}
