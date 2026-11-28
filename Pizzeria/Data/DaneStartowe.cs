using Pizzeria.Models.Klasy;
using Pizzeria.Models.Enums;

namespace Pizzeria.Data
{
    public static class DaneStartowe
    {
        public static void Wstaw()
        {
            var strefy = new StrefaRepository();
            if (strefy.PobierzWszystkie().Count == 0)
            {
                strefy.Dodaj(new StrefaDostawy(0, "Centrum", 5m, 30m));
                strefy.Dodaj(new StrefaDostawy(0, "Śródmieście", 5m, 30m));
                strefy.Dodaj(new StrefaDostawy(0, "Osiedle Zalesie", 8m, 40m));
                strefy.Dodaj(new StrefaDostawy(0, "Osiedle Nowe Miasto", 8m, 40m));
                strefy.Dodaj(new StrefaDostawy(0, "Staromieście", 7m, 35m));
                strefy.Dodaj(new StrefaDostawy(0, "Pobitno", 9m, 45m));
                strefy.Dodaj(new StrefaDostawy(0, "Słocina", 10m, 50m));
                strefy.Dodaj(new StrefaDostawy(0, "Zalesie", 10m, 50m));
                strefy.Dodaj(new StrefaDostawy(0, "Poza miastem", 12m, 60m));
                strefy.Dodaj(new StrefaDostawy(0, "Okolice dalekie", 15m, 80m));
            }

            var dodatki = new DodatekRepository();
            if (dodatki.PobierzWszystkie().Count == 0)
            {
                dodatki.Dodaj(new Dodatek(0, "Ser", 3m));
                dodatki.Dodaj(new Dodatek(0, "Pieczarki", 2.5m));
                dodatki.Dodaj(new Dodatek(0, "Szynka", 4m));
                dodatki.Dodaj(new Dodatek(0, "Oliwki", 2m));
                dodatki.Dodaj(new Dodatek(0, "Kukurydza", 2m));
                dodatki.Dodaj(new Dodatek(0, "Papryka", 2.5m));
                dodatki.Dodaj(new Dodatek(0, "Cebula", 1.5m));
                dodatki.Dodaj(new Dodatek(0, "Salami", 4.5m));
                dodatki.Dodaj(new Dodatek(0, "Ananas", 3m));
                dodatki.Dodaj(new Dodatek(0, "Bekon", 5m));
            }

            var klienci = new KlientRepository();
            if (klienci.PobierzWszystkie().Count == 0)
            {
                klienci.Dodaj(new Klient(0, "Jan", "Kowalski", "123456789", "Rzeszów, Polna 1", true));
                klienci.Dodaj(new Klient(0, "Anna", "Nowak", "987654321", "Rzeszów, Długa 5", false));
                klienci.Dodaj(new Klient(0, "Piotr", "Wójcik", "501234567", "Rzeszów, Lwowska 12", true));
                klienci.Dodaj(new Klient(0, "Katarzyna", "Kamińska", "502345678", "Rzeszów, Dąbrowskiego 8", false));
                klienci.Dodaj(new Klient(0, "Tomasz", "Lewandowski", "503456789", "Rzeszów, Kopisto 3", true));
                klienci.Dodaj(new Klient(0, "Magdalena", "Zielińska", "504567890", "Rzeszów, Staszica 21", false));
                klienci.Dodaj(new Klient(0, "Michał", "Szymański", "505678901", "Rzeszów, Witosa 15", false));
                klienci.Dodaj(new Klient(0, "Agnieszka", "Woźniak", "506789012", "Rzeszów, Piłsudskiego 7", true));
                klienci.Dodaj(new Klient(0, "Paweł", "Dąbrowski", "507890123", "Rzeszów, Rejtana 30", false));
                klienci.Dodaj(new Klient(0, "Ewa", "Kozłowska", "508901234", "Rzeszów, Krakowska 44", false));
            }

            var dostawcy = new DostawcaRepository();
            if (dostawcy.PobierzWszystkie().Count == 0)
            {
                dostawcy.Dodaj(new Dostawca(0, "Piotr", "Wiśniewski", "601111111", "Skuter"));
                dostawcy.Dodaj(new Dostawca(0, "Marek", "Zieliński", "602222222", "Samochód"));
                dostawcy.Dodaj(new Dostawca(0, "Krzysztof", "Jankowski", "603333333", "Rower"));
                dostawcy.Dodaj(new Dostawca(0, "Adam", "Mazur", "604444444", "Skuter"));
                dostawcy.Dodaj(new Dostawca(0, "Łukasz", "Krawczyk", "605555555", "Samochód"));
                dostawcy.Dodaj(new Dostawca(0, "Rafał", "Piotrowski", "606666666", "Rower"));
                dostawcy.Dodaj(new Dostawca(0, "Damian", "Grabowski", "607777777", "Skuter"));
                dostawcy.Dodaj(new Dostawca(0, "Jakub", "Pawłowski", "608888888", "Samochód"));
                dostawcy.Dodaj(new Dostawca(0, "Bartosz", "Michalski", "609999999", "Skuter"));
                dostawcy.Dodaj(new Dostawca(0, "Kamil", "Król", "610101010", "Rower"));
            }

            var produkty = new ProduktRepository();
            if (produkty.PobierzWszystkie().Count == 0)
            {
                produkty.Dodaj(new Pizza(0, "Margherita", 25m, RozmiarPizzy.Mala));
                produkty.Dodaj(new Pizza(0, "Margherita", 32m, RozmiarPizzy.Srednia));
                produkty.Dodaj(new Pizza(0, "Margherita", 40m, RozmiarPizzy.Duza));
                produkty.Dodaj(new Pizza(0, "Pepperoni", 30m, RozmiarPizzy.Mala));
                produkty.Dodaj(new Pizza(0, "Pepperoni", 38m, RozmiarPizzy.Srednia));
                produkty.Dodaj(new Pizza(0, "Pepperoni", 46m, RozmiarPizzy.Duza));
                produkty.Dodaj(new Pizza(0, "Hawajska", 34m, RozmiarPizzy.Srednia));
                produkty.Dodaj(new Napoj(0, "Cola", 7m, 500));
                produkty.Dodaj(new Napoj(0, "Woda", 5m, 330));
                produkty.Dodaj(new Napoj(0, "Sok pomarańczowy", 8m, 400));
            }
        }
    }
}