using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Pizzeria.Models.Enums;
using Pizzeria.Models.Klasy;

namespace Pizzeria.Data
{
    public class ProduktRepository
    {
        
        private static (string typ, object rozmiar, object pojemnosc) Rozpoznaj(Produkt produkt)
        {
            if (produkt is Pizza pizza)
            {
                return ("Pizza", (int)pizza.Rozmiar, DBNull.Value);
            }
            if (produkt is Napoj napoj)
            {
                return ("Napoj", DBNull.Value, napoj.Pojemnosc_Ml);
            }
            throw new ArgumentException("Nieznany typ produktu");
        }

        private static void ZapiszDodatki(SqliteConnection polaczenie, int pizzaId, Pizza pizza)
        {
            foreach (Dodatek dodatek in pizza.Dodatki)
            {
                var cmd = polaczenie.CreateCommand();
                cmd.CommandText = "INSERT INTO PizzaDodatki (PizzaId, DodatekId) VALUES (@pizza, @dodatek);";
                cmd.Parameters.AddWithValue("@pizza", pizzaId);
                cmd.Parameters.AddWithValue("@dodatek", dodatek.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public int Dodaj(Produkt produkt)
        {
            var (typ, rozmiar, pojemnosc) = Rozpoznaj(produkt);

            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "INSERT INTO Produkty (Typ, Nazwa, CenaBazowa, Rozmiar, PojemnoscMl) VALUES (@typ, @nazwa, @cena, @rozmiar, @pojemnosc);";
            cmd.Parameters.AddWithValue("@typ", typ);
            cmd.Parameters.AddWithValue("@nazwa", produkt.Nazwa);
            cmd.Parameters.AddWithValue("@cena", produkt.Cena_Bazowa);
            cmd.Parameters.AddWithValue("@rozmiar", rozmiar);
            cmd.Parameters.AddWithValue("@pojemnosc", pojemnosc);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT last_insert_rowid();";
            cmd.Parameters.Clear();
            int noweId = Convert.ToInt32(cmd.ExecuteScalar());

            if (produkt is Pizza pizza)
            {
                ZapiszDodatki(polaczenie, noweId, pizza);
            }
            return noweId;
        }

        public List<Produkt> PobierzWszystkie()
        {
            var lista = new List<Produkt>();
            using var polaczenie = Baza.PolaczZBaza();

            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "SELECT Id, Typ, Nazwa, CenaBazowa, Rozmiar, PojemnoscMl FROM Produkty;";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string typ = reader.GetString(1);
                    string nazwa = reader.GetString(2);
                    decimal cena = reader.GetDecimal(3);

                    if (typ == "Pizza")
                    {
                        RozmiarPizzy rozmiar = (RozmiarPizzy)reader.GetInt32(4);
                        lista.Add(new Pizza(id, nazwa, cena, rozmiar));
                    }
                    else if (typ == "Napoj")
                    {
                        int pojemnosc = reader.GetInt32(5);
                        lista.Add(new Napoj(id, nazwa, cena, pojemnosc));
                    }
                }
            }

      
            foreach (Produkt produkt in lista)
            {
                if (produkt is Pizza pizza)
                {
                    var cmdDodatki = polaczenie.CreateCommand();
                    cmdDodatki.CommandText = "SELECT d.Id, d.Nazwa, d.Cena FROM Dodatki d JOIN PizzaDodatki pd ON pd.DodatekId = d.Id WHERE pd.PizzaId = @id;";
                    cmdDodatki.Parameters.AddWithValue("@id", pizza.Id);
                    using var readerDodatki = cmdDodatki.ExecuteReader();
                    while (readerDodatki.Read())
                    {
                        pizza.DodajDodatek(new Dodatek(readerDodatki.GetInt32(0), readerDodatki.GetString(1), readerDodatki.GetDecimal(2)));
                    }
                }
            }
            return lista;
        }

        public void Zmien(Produkt produkt)
        {
            var (typ, rozmiar, pojemnosc) = Rozpoznaj(produkt);

            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "UPDATE Produkty SET Nazwa=@nazwa, CenaBazowa=@cena, Rozmiar=@rozmiar, PojemnoscMl=@pojemnosc WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@nazwa", produkt.Nazwa);
            cmd.Parameters.AddWithValue("@cena", produkt.Cena_Bazowa);
            cmd.Parameters.AddWithValue("@rozmiar", rozmiar);
            cmd.Parameters.AddWithValue("@pojemnosc", pojemnosc);
            cmd.Parameters.AddWithValue("@id", produkt.Id);
            cmd.ExecuteNonQuery();

            if (produkt is Pizza pizza)
            {
                var cmdUsun = polaczenie.CreateCommand();
                cmdUsun.CommandText = "DELETE FROM PizzaDodatki WHERE PizzaId=@id;";
                cmdUsun.Parameters.AddWithValue("@id", produkt.Id);
                cmdUsun.ExecuteNonQuery();
                ZapiszDodatki(polaczenie, produkt.Id, pizza);
            }
        }

        public void Usun(int id)
        {
            using var polaczenie = Baza.PolaczZBaza();

            var cmdDodatki = polaczenie.CreateCommand();
            cmdDodatki.CommandText = "DELETE FROM PizzaDodatki WHERE PizzaId=@id;";
            cmdDodatki.Parameters.AddWithValue("@id", id);
            cmdDodatki.ExecuteNonQuery();

            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "DELETE FROM Produkty WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}