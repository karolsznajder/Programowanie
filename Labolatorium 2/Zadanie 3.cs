using System;
using System.Collections.Generic;

class Student
{
    public string Imie { get; }
    public string Nazwisko { get; }
    private List<int> oceny;

    public double SredniaOcen => oceny.Count > 0 ? (double)oceny.Sum() / oceny.Count : 0;

    public Student(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        oceny = new List<int>();
    }

    public void DodajOcene(int ocena)
    {
        if (ocena >= 1 && ocena <= 6) oceny.Add(ocena);
        else Console.WriteLine("Ocena musi być w przedziale 1-6.");
    }

    public void WyswietlOceny()
    {
        Console.WriteLine("Oceny: " + string.Join(", ", oceny));
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Kasia", "Nowak");
        student.DodajOcene(5);
        student.DodajOcene(3);
        student.WyswietlOceny();
        Console.WriteLine($"Średnia ocen: {student.SredniaOcen}");
    }
}
