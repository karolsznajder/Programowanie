class Reviewer : Reader
{
    public Reviewer(string firstName, string lastName, int wiek) : base(firstName, lastName, wiek) { }

    public void Wypisz()
    {
        Random rand = new Random();
        Console.WriteLine($"Oceny książek przeczytanych przez {FirstName} {LastName}:");
        foreach (Book ksiazka in przeczytaneKsiazki)
        {
            Console.WriteLine($"- {ksiazka.Title}: Ocena {rand.Next(1, 10)}");
        }
    }
}
