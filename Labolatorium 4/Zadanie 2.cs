using System;
using System.Collections.Generic;

class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Pesel { get; set; }

    public void SetFirstName(string name) => Imie = name;
    public void SetLastName(string surname) => Nazwisko = surname;
    public void SetPesel(string pesel) => Pesel = pesel;

    public int GetAge()
    {
        int year = int.Parse(Pesel.Substring(0, 2));
        int month = int.Parse(Pesel.Substring(2, 2));
        year += (month > 12) ? 2000 : 1900;
        return DateTime.Now.Year - year;
    }

    public string GetGender() => (int.Parse(Pesel[9].ToString()) % 2 == 0) ? "Kobieta" : "Mężczyzna";

    public virtual string GetFullName() => $"{Imie} {Nazwisko}";
}

class Uczen : Osoba
{
    public string Szkola { get; set; }
    public bool MozeSamWracacDoDomu { get; set; }

    public void SetSchool(string szkola) => Szkola = szkola;
    public void SetCanGoHomeAlone(bool canGo) => MozeSamWracacDoDomu = canGo;

    public bool CanGoAloneToHome() => GetAge() >= 12 || MozeSamWracacDoDomu;
}

class Nauczyciel : Uczen
{
    public string TytulNaukowy { get; set; }
    public List<Uczen> PodwladniUczniowie { get; set; } = new List<Uczen>();

    public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
    {
        foreach (var uczen in PodwladniUczniowie)
        {
            if (uczen.CanGoAloneToHome())
                Console.WriteLine($"{uczen.GetFullName()} może wracać do domu.");
        }
    }
}
