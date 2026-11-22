using Microsoft.Data.Sqlite;
using Pizzeria.Models.Enums;
using Pizzeria.Models.Klasy;
using System;
using System.Collections.Generic;


namespace Pizzeria.Data
{
    public class DostawcaRepository
    {
        public int Dodaj(Dostawca dostawca)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "INSERT INTO Dostawcy (Imie, Nazwisko, Telefon, Pojazd, Status, LiczbaDostaw) VALUES (@imie, @nazwisko, @telefon, @pojazd, @status, @liczba);";
            cmd.Parameters.AddWithValue("@imie",dostawca.Imie);
            cmd.Parameters.AddWithValue("@nazwisko", dostawca.Nazwisko);
            cmd.Parameters.AddWithValue("@telefon", dostawca.Telefon);
            cmd.Parameters.AddWithValue("@pojazd", dostawca.Pojazd);
            cmd.Parameters.AddWithValue("@status", (int)dostawca.Status_Dostawcy);
            cmd.Parameters.AddWithValue("@liczba", dostawca.Liczba_Dostaw);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT last_insert_rowid();";
            cmd.Parameters.Clear();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public List<Dostawca> PobierzWszystkie()
        {
            var lista = new List<Dostawca>();
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "SELECT Id, Imie, Nazwisko, Telefon, Pojazd, Status, LiczbaDostaw FROM Dostawcy;";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string imie = reader.GetString(1);
                string nazwisko = reader.GetString(2);
                string telefon = reader.GetString(3);
                string pojazd = reader.GetString(4);
                StatusDostawcy status = (StatusDostawcy)reader.GetInt32(5);
                int liczba = reader.GetInt32(6);
                Dostawca dostawca = new Dostawca(id, imie, nazwisko, telefon, pojazd, status, liczba);
                lista.Add(dostawca);
            }
            return lista;
        }

        public void Zmien(Dostawca dostawca)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "UPDATE Dostawcy SET Imie=@imie, Nazwisko=@nazwisko, Telefon=@telefon, Pojazd=@pojazd, Status=@status, LiczbaDostaw=@liczba WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@imie", dostawca.Imie);
            cmd.Parameters.AddWithValue("@nazwisko", dostawca.Nazwisko);
            cmd.Parameters.AddWithValue("@telefon", dostawca.Telefon);
            cmd.Parameters.AddWithValue("@pojazd", dostawca.Pojazd);
            cmd.Parameters.AddWithValue("@status", (int)dostawca.Status_Dostawcy);
            cmd.Parameters.AddWithValue("@liczba", dostawca.Liczba_Dostaw);
            cmd.Parameters.AddWithValue("@id", dostawca.Id);
            cmd.ExecuteNonQuery();
        }

        public void Usun(int id)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "DELETE FROM Dostawcy WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
