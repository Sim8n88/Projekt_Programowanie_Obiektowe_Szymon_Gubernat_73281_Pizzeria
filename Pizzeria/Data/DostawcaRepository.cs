using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Pizzeria.Models.Enums;
using Pizzeria.Models.Klasy;

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
    }
}
