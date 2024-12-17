using System;
using System.Collections.Generic;

class Reader : Person
{
    private List<Book> przeczytaneKsiazki;

    public Reader(string firstName, string lastName, int wiek) 
        : base(firstName, lastName, wiek)
    {
        przeczytaneKsiazki = new List<Book>();
    }

    public void DodajKsiazke(Book ksiazka)
    {
        przeczytaneKsiazki.Add(ksiazka);
    }

    public void ViewBook()
    {
        Console.WriteLine($"Książki przeczytane przez {FirstName} {LastName}:");
        foreach (Book ksiazka in przeczytaneKsiazki)
        {
            Console.WriteLine($"- {ksiazka.Title}");
        }
    }
}

class Program
{
    static void Main()
    {
        Person author1 = new Person("Adam", "Mickiewicz", 220);
        Book book1 = new Book("Pan Tadeusz", author1, 1834);
        Book book2 = new Book("Dziady", author1, 1823);

        Reader czytelnik = new Reader("Jan", "Kowalski", 30);
        czytelnik.DodajKsiazke(book1);
        czytelnik.DodajKsiazke(book2);

        czytelnik.ViewBook();
    }
}
