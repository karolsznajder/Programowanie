using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] liczby = new double[10];
        Console.WriteLine("Podaj 10 liczb:");
        for (int i = 0; i < 10; i++) liczby[i] = double.Parse(Console.ReadLine());

        double suma = liczby.Sum();
        double iloczyn = liczby.Aggregate(1.0, (x, y) => x * y);
        double srednia = suma / liczby.Length;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Iloczyn: {iloczyn}");
        Console.WriteLine($"Średnia: {srednia}");
        Console.WriteLine($"Min: {liczby.Min()}");
        Console.WriteLine($"Max: {liczby.Max()}");
    }
}
