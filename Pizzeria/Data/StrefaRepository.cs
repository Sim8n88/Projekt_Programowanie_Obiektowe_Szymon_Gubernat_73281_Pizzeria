using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.Sqlite;
using Pizzeria.Models.Klasy;
namespace Pizzeria.Data
{
    public class StrefaRepository
    {
        public int Dodaj(StrefaDostawy strefa)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = @"INSERT INTO StrefyDostawy (Nazwa,KosztDowozu,MinimalnaKwota) VALUES (@nazwa,@koszt,@minimalna);";
            cmd.Parameters.AddWithValue("@nazwa", strefa.Nazwa);
            cmd.Parameters.AddWithValue("@koszt", strefa.Koszt_Dowozu);
            cmd.Parameters.AddWithValue("@minimalna", strefa.Minimalna_Kwota);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT last_insert_rowid();";
            cmd.Parameters.Clear();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public List<StrefaDostawy> PobierzWszystkie()
        {
            var lista = new List<StrefaDostawy>();
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "SELECT Id, Nazwa, KosztDowozu, MinimalnaKwota FROM StrefyDostawy;";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nazwa = reader.GetString(1);
                decimal koszt = reader.GetDecimal(2);
                decimal minimalna = reader.GetDecimal(3);
                StrefaDostawy strefa= new StrefaDostawy(id, nazwa, koszt, minimalna);
                lista.Add(strefa);
            }
            return lista;
        }
        public void Usun(int id)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "DELETE FROM StrefyDostawy WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        public void Zmien(StrefaDostawy strefa)
        {
            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "UPDATE StrefyDostawy SET Nazwa=@nazwa,KosztDowozu=@koszt,MinimalnaKwota=@minimalna WHERE Id=@id";
            cmd.Parameters.AddWithValue("@nazwa", strefa.Nazwa);
            cmd.Parameters.AddWithValue("@koszt", strefa.Koszt_Dowozu);
            cmd.Parameters.AddWithValue("@minimalna", strefa.Minimalna_Kwota);
            cmd.Parameters.AddWithValue("@id", strefa.Id);
            cmd.ExecuteNonQuery();
        }
    }
}
