using System;

class Sumator
{
    private int[] liczby;

    public Sumator(int[] liczby)
    {
        this.liczby = liczby;
    }

    public int Suma()
    {
        int suma = 0;
        foreach (int liczba in liczby) suma += liczba;
        return suma;
    }

    public int SumaPodziel2()
    {
        int suma = 0;
        foreach (int liczba in liczby)
            if (liczba % 2 == 0) suma += liczba;
        return suma;
    }

    public int IleElementow() => liczby.Length;

    public void WypiszElementy()
    {
        Console.WriteLine("Elementy tablicy: " + string.Join(", ", liczby));
    }

    public void WypiszZakres(int lowIndex, int highIndex)
    {
        for (int i = Math.Max(lowIndex, 0); i <= Math.Min(highIndex, liczby.Length - 1); i++)
        {
            Console.Write(liczby[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Sumator sumator = new Sumator(liczby);

        Console.WriteLine($"Suma: {sumator.Suma()}");
        Console.WriteLine($"Suma podzielnych przez 2: {sumator.SumaPodziel2()}");
        Console.WriteLine($"Liczba elementów: {sumator.IleElementow()}");

        sumator.WypiszElementy();
        sumator.WypiszZakres(2, 7);
    }
}
