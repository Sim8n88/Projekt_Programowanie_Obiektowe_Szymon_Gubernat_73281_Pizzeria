using Microsoft.Data.Sqlite;
using Pizzeria.Models.Klasy;
using System;
using System.Collections;
using System.Collections.Generic;

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
        public List<Dodatek> PobierzWszystkie()
        {
            var lista = new List<Dodatek>();
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "SELECT Id,Nazwa,Cena FROM Dodatki;";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id=reader.GetInt32(0);
                string nazwa=reader.GetString(1);
                decimal cena reader.GetDecimal(2);
                Dodatek dodatek = new Dodatek(id, nazwa, cena);
            }
        }
    }
        
}
