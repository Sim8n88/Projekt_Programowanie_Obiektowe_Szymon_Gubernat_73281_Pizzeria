using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Pizzeria.Models.Klasy;

namespace Pizzeria.Data
{
    public class KlientRepository
    {
        public int Dodaj(Klient klient)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "INSERT INTO Klienci (Imie, Nazwisko, Telefon, Adres, StalyKlient) VALUES (@imie, @nazwisko, @telefon, @adres, @staly);";
            cmd.Parameters.AddWithValue("@imie", klient.Imie);
            cmd.Parameters.AddWithValue("@nazwisko", klient.Nazwisko);
            cmd.Parameters.AddWithValue("@telefon", klient.Telefon);
            cmd.Parameters.AddWithValue("@adres", klient.Adres);
            cmd.Parameters.AddWithValue("@staly", klient.Staly_Klient);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT last_insert_rowid();";
            cmd.Parameters.Clear();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
