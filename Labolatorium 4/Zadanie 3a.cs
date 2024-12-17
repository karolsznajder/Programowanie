interface IOsoba
{
    string Imie { get; set; }
    string Nazwisko { get; set; }
    string ZwrocPelnaNazwe();
}

class Osoba : IOsoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }

    public string ZwrocPelnaNazwe() => $"{Imie} {Nazwisko}";
}
