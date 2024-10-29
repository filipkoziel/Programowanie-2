
using LinqConsoleApp;

List<Person> people = new List<Person>();

#region Uzupełnienie kolekcji

Person person = new Person();
person.Name = "Ewa";
person.Surname = "Kowalska";
person.Age = 32;

people.Add(person);

person.Name = "Jan";
person.Surname = "Nowak";
person.Age = 12;

people.Add(person);

person.Name = "Karol";
person.Surname = "Krawczyk";
person.Age = 52;

people.Add(person);

person.Name = "Paweł";
person.Surname = "Nowakowski";
person.Age = 35;

#endregion

Console.WriteLine("Główna kolekcja:");
//for (int i = 0; i < people.Count; i++)
//{
//    Console.WriteLine($"Imię: {people[i].Name} Nazwisko: {people[i].Surname} Wiek: {people[i].Age}");
//}

foreach (Person p in people)
{
    Console.WriteLine($"Imię: {p.Name} Nazwisko: {p.Surname} Wiek: {p.Age}");
}

List<Person> sortedPeopleByAge = people.OrderBy(p => p.Age).ToList();
foreach (Person p in sortedPeopleByAge)
{
    Console.WriteLine($"Imię: {p.Name} Nazwisko: {p.Surname} Wiek: {p.Age}");
}

int maxAge = people.Max(p => p.Age);
Console.WriteLine($"Najstarsza osoba ma {maxAge} lat.");

double avgAge = people.Average(p => p.Age);
Console.WriteLine($"Średni wiek to {avgAge} lat.");