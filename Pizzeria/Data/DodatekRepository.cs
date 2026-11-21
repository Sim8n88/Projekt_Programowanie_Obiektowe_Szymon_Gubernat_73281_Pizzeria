using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Pizzeria.Models.Klasy;

namespace Pizzeria.Data
{
    public class DodatekRepository
    {
        public int Dodaj(Dodatek dodatek)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "INSERT INTO Dodatki (Nazwa, Cena) VALUES (@nazwa, @cena);";
            cmd.Parameters.AddWithValue("@nazwa", dodatek.Nazwa);
            cmd.Parameters.AddWithValue("@cena", dodatek.Cena);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT last_insert_rowid();";
            cmd.Parameters.Clear();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
