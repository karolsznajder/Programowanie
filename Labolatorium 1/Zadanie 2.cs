using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nWybierz operację:\n1-Suma\n2-Różnica\n3-Iloczyn\n4-Iloraz\n5-Potęga\n6-Pierwiastek\n7-Funkcje trygonometryczne\n8-Wyjście");
            int opcja = int.Parse(Console.ReadLine());

            if (opcja == 8) break;

            Console.Write("Podaj liczbę a: ");
            double a = double.Parse(Console.ReadLine());

            double b = 0;
            if (opcja < 6)
            {
                Console.Write("Podaj liczbę b: ");
                b = double.Parse(Console.ReadLine());
            }

            switch (opcja)
            {
                case 1: Console.WriteLine($"Suma = {a + b}"); break;
                case 2: Console.WriteLine($"Różnica = {a - b}"); break;
                case 3: Console.WriteLine($"Iloczyn = {a * b}"); break;
                case 4: Console.WriteLine($"Iloraz = {a / b}"); break;
                case 5: Console.WriteLine($"Potęga = {Math.Pow(a, b)}"); break;
                case 6: Console.WriteLine($"Pierwiastek = {Math.Sqrt(a)}"); break;
                case 7:
                    Console.WriteLine($"Sinus = {Math.Sin(a)}");
                    Console.WriteLine($"Cosinus = {Math.Cos(a)}");
                    Console.WriteLine($"Tangens = {Math.Tan(a)}");
                    break;
                default: Console.WriteLine("Nieznana opcja."); break;
            }
        }
    }
}
