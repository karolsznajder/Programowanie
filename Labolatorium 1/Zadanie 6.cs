using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba < 0) break;
        }
        Console.WriteLine("Koniec programu.");
    }
}
