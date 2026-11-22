using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
namespace Pizzeria.Data
{
    public static class Baza
    {
        private const string NazwaPliku = "pizzeria.db";
        public static SqliteConnection PolaczZBaza()
        {
            var polaczenie = new SqliteConnection($"Data Source={NazwaPliku}");
            polaczenie.Open();
            return polaczenie;
        }
        public static void Inicjalizuj()
        {
            using var polaczenie = PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = @"
        CREATE TABLE IF NOT EXISTS StrefyDostawy (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Nazwa TEXT NOT NULL,
            KosztDowozu REAL NOT NULL,
            MinimalnaKwota REAL NOT NULL
        );";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Dodatki (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nazwa TEXT NOT NULL,
                Cena REAL NOT NULL);";
            cmd.ExecuteNonQuery();

        }
    }
}
