interface IStudent : IOsoba
{
    string Uczelnia { get; set; }
    string Kierunek { get; set; }
    int Rok { get; set; }
    int Semestr { get; set; }
}

class Student : IStudent
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Uczelnia { get; set; }
    public string Kierunek { get; set; }
    public int Rok { get; set; }
    public int Semestr { get; set; }

    public string ZwrocPelnaNazwe() => $"{Imie} {Nazwisko}";
    public string WypiszPelnaNazweIUczelnie() => $"{ZwrocPelnaNazwe()} – {Semestr} {Kierunek} {Uczelnia}";
}
