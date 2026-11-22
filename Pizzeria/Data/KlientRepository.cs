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
        public List<Klient> PobierzWszystkie()
        {
            var lista = new List<Klient>();
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "SELECT Id, Imie, Nazwisko, Telefon, Adres, StalyKlient FROM Klienci;";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string imie = reader.GetString(1);
                string nazwisko = reader.GetString(2);
                string telefon = reader.GetString(3);
                string adres = reader.GetString(4);
                bool staly = reader.GetBoolean(5);
                Klient klient = new Klient(id, imie, nazwisko, telefon, adres, staly);
                lista.Add(klient);
            }
            return lista;
        }

        public void Zmien(Klient klient)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "UPDATE Klienci SET Imie=@imie, Nazwisko=@nazwisko, Telefon=@telefon, Adres=@adres, StalyKlient=@staly WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@imie", klient.Imie);
            cmd.Parameters.AddWithValue("@nazwisko", klient.Nazwisko);
            cmd.Parameters.AddWithValue("@telefon", klient.Telefon);
            cmd.Parameters.AddWithValue("@adres", klient.Adres);
            cmd.Parameters.AddWithValue("@staly", klient.Staly_Klient);
            cmd.Parameters.AddWithValue("@id", klient.Id);
            cmd.ExecuteNonQuery();
        }

        public void Usun(int id)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "DELETE FROM Klienci WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
