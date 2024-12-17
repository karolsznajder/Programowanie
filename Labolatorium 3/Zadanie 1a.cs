using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Wiek { get; set; }

    public Person(string firstName, string lastName, int wiek)
    {
        FirstName = firstName;
        LastName = lastName;
        Wiek = wiek;
    }

    public virtual void View()
    {
        Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}, Wiek: {Wiek}");
    }
}

class Book
{
    public string Title { get; set; }
    public Person Author { get; set; }
    public int DataWydania { get; set; }

    public Book(string title, Person author, int dataWydania)
    {
        Title = title;
        Author = author;
        DataWydania = dataWydania;
    }

    public void View()
    {
        Console.WriteLine($"Tytuł: {Title}, Autor: {Author.FirstName} {Author.LastName}, Rok wydania: {DataWydania}");
    }
}

class Program
{
    static void Main()
    {
        Person author = new Person("Adam", "Mickiewicz", 220);
        Book book1 = new Book("Pan Tadeusz", author, 1834);

        author.View();
        book1.View();
    }
}
