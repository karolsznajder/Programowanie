using System;

class Program
{
    static void Main()
    {
        double[] tablica = new double[10];
        Console.WriteLine("Podaj 10 liczb:");
        for (int i = 0; i < 10; i++)
        {
            tablica[i] = double.Parse(Console.ReadLine());
        }

        int wybor;
        do
        {
            Console.WriteLine("\nMenu:\n1-Od pierwszego do ostatniego\n2-Od ostatniego do pierwszego\n3-Indeksy nieparzyste\n4-Indeksy parzyste\n5-Wyjście");
            wybor = int.Parse(Console.ReadLine());

            if (wybor == 1)
                for (int i = 0; i < 10; i++) Console.Write(tablica[i] + " ");
            else if (wybor == 2)
                for (int i = 9; i >= 0; i--) Console.Write(tablica[i] + " ");
            else if (wybor == 3)
                for (int i = 1; i < 10; i += 2) Console.Write(tablica[i] + " ");
            else if (wybor == 4)
                for (int i = 0; i < 10; i += 2) Console.Write(tablica[i] + " ");
        }
        while (wybor != 5);
    }
}
