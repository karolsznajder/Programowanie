using System;

class Licz
{
    private int value;

    public Licz(int startValue)
    {
        value = startValue;
    }

    public void Dodaj(int liczba) => value += liczba;

    public void Odejmij(int liczba) => value -= liczba;

    public void WyswietlStan() => Console.WriteLine($"Wartość: {value}");
}

class Program
{
    static void Main()
    {
        Licz licz1 = new Licz(10);
        licz1.Dodaj(5);
        licz1.Odejmij(3);
        licz1.WyswietlStan();
    }
}
