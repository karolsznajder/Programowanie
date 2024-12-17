using System;

class Samochod
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Nadwozie { get; set; }
    public string Kolor { get; set; }
    public int RokProdukcji { get; set; }
    private int przebieg;

    public int Przebieg
    {
        get => przebieg;
        set
        {
            if (value >= 0) przebieg = value;
            else Console.WriteLine("Przebieg nie może być ujemny.");
        }
    }

    public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg)
    {
        Marka = marka;
        Model = model;
        Nadwozie = nadwozie;
        Kolor = kolor;
        RokProdukcji = rokProdukcji;
        Przebieg = przebieg;
    }

    public virtual void View()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Nadwozie: {Nadwozie}, Kolor: {Kolor}, Rok: {RokProdukcji}, Przebieg: {Przebieg}");
    }
}

class SamochodOsobowy : Samochod
{
    public double Waga { get; set; }
    public double PojemnoscSilnika { get; set; }
    public int IloscOsob { get; set; }

    public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg, double waga, double pojemnoscSilnika, int iloscOsob)
        : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
    {
        Waga = waga;
        PojemnoscSilnika = pojemnoscSilnika;
        IloscOsob = iloscOsob;
    }

    public override void View()
    {
        base.View();
        Console.WriteLine($"Waga: {Waga} t, Pojemność silnika: {PojemnoscSilnika} l, Ilość osób: {IloscOsob}");
    }
}

class Program
{
    static void Main()
    {
        SamochodOsobowy osobowy = new SamochodOsobowy("Toyota", "Corolla", "Sedan", "Czerwony", 2020, 15000, 2.5, 1.6, 5);
        Samochod zwykly1 = new Samochod("Ford", "Focus", "Hatchback", "Niebieski", 2019, 20000);
        Samochod zwykly2 = new Samochod("BMW", "X5", "SUV", "Czarny", 2021, 5000);

        osobowy.View();
        zwykly1.View();
        zwykly2.View();
    }
}
