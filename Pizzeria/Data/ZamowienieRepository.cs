using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.Data.Sqlite;
using Pizzeria.Models.Enums;
using Pizzeria.Models.Klasy;

namespace Pizzeria.Data
{
    public class ZamowienieRepository
    {
        private static (string typ, object godzina, object adres, object strefaId, object dostawcaId) Rozpoznaj(Zamowienie zamowienie)
        {
            if (zamowienie is ZamowienieNaWynos wynos)
            {
                return ("Wynos", wynos.Godzina_Odbioru.ToString("o", CultureInfo.InvariantCulture), DBNull.Value, DBNull.Value, DBNull.Value);
            }
            if (zamowienie is ZamowienieZDostawa dostawa)
            {
                object dostawcaId = dostawa.Dostawca != null ? (object)dostawa.Dostawca.Id : DBNull.Value;
                return ("Dostawa", DBNull.Value, dostawa.Adres_Dostawy, dostawa.Strefa.Id, dostawcaId);
            }
            throw new ArgumentException("Nieznany typ zamówienia");
        }

        private static void ZapiszPozycje(SqliteConnection polaczenie, int zamowienieId, Zamowienie zamowienie)
        {
            foreach (PozycjaZamowienia pozycja in zamowienie.Pozycje)
            {
                var cmd = polaczenie.CreateCommand();
                cmd.CommandText = "INSERT INTO PozycjeZamowienia (ZamowienieId, ProduktId, Ilosc, CenaJednostkowa) VALUES (@zamowienie, @produkt, @ilosc, @cena);";
                cmd.Parameters.AddWithValue("@zamowienie", zamowienieId);
                cmd.Parameters.AddWithValue("@produkt", pozycja.Produkt.Id);
                cmd.Parameters.AddWithValue("@ilosc", pozycja.Ilosc);
                cmd.Parameters.AddWithValue("@cena", pozycja.Cena_Jednostkowa);
                cmd.ExecuteNonQuery();
            }
        }

        public int Dodaj(Zamowienie zamowienie)
        {
            var (typ, godzina, adres, strefaId, dostawcaId) = Rozpoznaj(zamowienie);

            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "INSERT INTO Zamowienia (Typ, KlientId, Status, DataZlozenia, GodzinaOdbioru, AdresDostawy, StrefaId, DostawcaId) VALUES (@typ, @klient, @status, @data, @godzina, @adres, @strefa, @dostawca);";
            cmd.Parameters.AddWithValue("@typ", typ);
            cmd.Parameters.AddWithValue("@klient", zamowienie.Klient.Id);
            cmd.Parameters.AddWithValue("@status", (int)zamowienie.Status);
            cmd.Parameters.AddWithValue("@data", zamowienie.Data_Zlozenia.ToString("o", CultureInfo.InvariantCulture));
            cmd.Parameters.AddWithValue("@godzina", godzina);
            cmd.Parameters.AddWithValue("@adres", adres);
            cmd.Parameters.AddWithValue("@strefa", strefaId);
            cmd.Parameters.AddWithValue("@dostawca", dostawcaId);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT last_insert_rowid();";
            cmd.Parameters.Clear();
            int noweId = Convert.ToInt32(cmd.ExecuteScalar());

            ZapiszPozycje(polaczenie, noweId, zamowienie);
            return noweId;
        }

        public List<Zamowienie> PobierzWszystkie()
        {
            var klienci = new KlientRepository().PobierzWszystkie().ToDictionary(k => k.Id);
            var strefy = new StrefaRepository().PobierzWszystkie().ToDictionary(s => s.Id);
            var dostawcy = new DostawcaRepository().PobierzWszystkie().ToDictionary(d => d.Id);
            var produkty = new ProduktRepository().PobierzWszystkie().ToDictionary(p => p.Id);

            var lista = new List<Zamowienie>();
            var statusy = new Dictionary<int, StatusZamowienia>();

            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "SELECT Id, Typ, KlientId, Status, DataZlozenia, GodzinaOdbioru, AdresDostawy, StrefaId, DostawcaId FROM Zamowienia;";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string typ = reader.GetString(1);
                    Klient klient = klienci[reader.GetInt32(2)];
                    StatusZamowienia status = (StatusZamowienia)reader.GetInt32(3);
                    DateTime data = DateTime.Parse(reader.GetString(4), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

                    Zamowienie zamowienie;
                    if (typ == "Wynos")
                    {
                        DateTime godzina = DateTime.Parse(reader.GetString(5), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                        zamowienie = new ZamowienieNaWynos(id, klient, godzina, data);
                    }
                    else
                    {
                        string adres = reader.GetString(6);
                        StrefaDostawy strefa = strefy[reader.GetInt32(7)];
                        var dostawa = new ZamowienieZDostawa(id, klient, adres, strefa, data);
                        if (!reader.IsDBNull(8))
                        {
                            dostawa.Dostawca = dostawcy[reader.GetInt32(8)];
                        }
                        zamowienie = dostawa;
                    }
                    lista.Add(zamowienie);
                    statusy[id] = status;
                }
            }

            foreach (Zamowienie z in lista)
            {
                var cmdPozycje = polaczenie.CreateCommand();
                cmdPozycje.CommandText = "SELECT Id, ProduktId, Ilosc, CenaJednostkowa FROM PozycjeZamowienia WHERE ZamowienieId=@id;";
                cmdPozycje.Parameters.AddWithValue("@id", z.Id);
                using var readerPozycje = cmdPozycje.ExecuteReader();
                while (readerPozycje.Read())
                {
                    z.DodajPozycje(new PozycjaZamowienia(
                        readerPozycje.GetInt32(0),
                        produkty[readerPozycje.GetInt32(1)],
                        readerPozycje.GetInt32(2),
                        readerPozycje.GetDecimal(3)));
                }
                z.PrzywrocStatus(statusy[z.Id]);
            }
            return lista;
        }

        public void Zmien(Zamowienie zamowienie)
        {
            var (_, godzina, adres, strefaId, dostawcaId) = Rozpoznaj(zamowienie);

            using var polaczenie = Baza.PolaczZBaza();
            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "UPDATE Zamowienia SET KlientId=@klient, Status=@status, GodzinaOdbioru=@godzina, AdresDostawy=@adres, StrefaId=@strefa, DostawcaId=@dostawca WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@klient", zamowienie.Klient.Id);
            cmd.Parameters.AddWithValue("@status", (int)zamowienie.Status);
            cmd.Parameters.AddWithValue("@godzina", godzina);
            cmd.Parameters.AddWithValue("@adres", adres);
            cmd.Parameters.AddWithValue("@strefa", strefaId);
            cmd.Parameters.AddWithValue("@dostawca", dostawcaId);
            cmd.Parameters.AddWithValue("@id", zamowienie.Id);
            cmd.ExecuteNonQuery();

            var cmdUsun = polaczenie.CreateCommand();
            cmdUsun.CommandText = "DELETE FROM PozycjeZamowienia WHERE ZamowienieId=@id;";
            cmdUsun.Parameters.AddWithValue("@id", zamowienie.Id);
            cmdUsun.ExecuteNonQuery();
            ZapiszPozycje(polaczenie, zamowienie.Id, zamowienie);
        }

        public void Usun(int id) 
        {
            using var polaczenie = Baza.PolaczZBaza();

            var cmdPozycje = polaczenie.CreateCommand();
            cmdPozycje.CommandText = "DELETE FROM PozycjeZamowienia WHERE ZamowienieId=@id;";
            cmdPozycje.Parameters.AddWithValue("@id", id);
            cmdPozycje.ExecuteNonQuery();

            var cmd = polaczenie.CreateCommand();
            cmd.CommandText = "DELETE FROM Zamowienia WHERE Id=@id;";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}