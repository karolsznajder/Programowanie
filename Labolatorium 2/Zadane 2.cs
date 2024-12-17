using System;

class BankAccount
{
    private decimal saldo;

    public decimal Saldo => saldo; // Tylko do odczytu
    public string Wlasciciel { get; }

    public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
    {
        Wlasciciel = wlasciciel;
        saldo = poczatkoweSaldo > 0 ? poczatkoweSaldo : throw new ArgumentException("Saldo musi być dodatnie.");
    }

    public void Wplata(decimal kwota)
    {
        if (kwota > 0) saldo += kwota;
        else Console.WriteLine("Kwota wpłaty musi być dodatnia.");
    }

    public void Wyplata(decimal kwota)
    {
        if (kwota > 0 && kwota <= saldo) saldo -= kwota;
        else Console.WriteLine("Niewystarczające środki lub niepoprawna kwota.");
    }
}

class Program
{
    static void Main()
    {
        BankAccount konto = new BankAccount("Jan Kowalski", 1000);
        konto.Wplata(500);
        konto.Wyplata(200);
        Console.WriteLine($"Saldo: {konto.Saldo}");
    }
}
