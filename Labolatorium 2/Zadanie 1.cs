using System;

class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;

    public string Imie
    {
        get => imie;
        set
        {
            if (value.Length >= 2) imie = value;
            else throw new ArgumentException("Imię musi mieć co najmniej 2 znaki.");
        }
    }

    public string Nazwisko
    {
        get => nazwisko;
        set
        {
            if (value.Length >= 2) nazwisko = value;
            else throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki.");
        }
    }

    public int Wiek
    {
        get => wiek;
        set
        {
            if (value > 0) wiek = value;
            else throw new ArgumentException("Wiek musi być dodatni.");
        }
    }

    public Osoba(string imie, string nazwisko, int wiek)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Wiek = wiek;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
    }
}

class Program
{
    static void Main()
    {
        Osoba osoba = new Osoba("Anna", "Kowalska", 25);
        osoba.WyswietlInformacje();
    }
}
