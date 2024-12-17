using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współczynniki a, b, c trójmianu kwadratowego:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        ObliczPierwiastki(a, b, c);
    }

    static void ObliczPierwiastki(double a, double b, double c)
    {
        double delta = (b * b) - (4 * a * c);
        Console.WriteLine($"Delta = {delta}");

        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Pierwiastki rzeczywiste: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x0 = -b / (2 * a);
            Console.WriteLine($"Jeden pierwiastek rzeczywisty: x0 = {x0}");
        }
        else
        {
            Console.WriteLine("Brak pierwiastków rzeczywistych.");
        }
    }
}
