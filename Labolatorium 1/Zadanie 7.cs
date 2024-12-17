using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());
        int[] liczby = new int[n];

        Console.WriteLine("Podaj liczby:");
        for (int i = 0; i < n; i++) liczby[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (liczby[j] > liczby[j + 1])
                {
                    int temp = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Posortowane liczby:");
        foreach (int liczba in liczby) Console.Write(liczba + " ");
    }
}
