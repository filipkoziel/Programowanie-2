
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

people.Add(person);

person.Name = "Paweł";
person.Surname = "Nowak";
person.Age = 5;

people.Add(person);

person.Name = "Karol";
person.Surname = "Nowak";
person.Age = 23;

people.Add(person);

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
Console.WriteLine();

double avgAge = people.Average(p => p.Age);
Console.WriteLine($"Średni wiek to {avgAge} lat.");
Console.WriteLine();

Console.Clear();

List<Person> sortedPeople = people.OrderBy(p => p.Surname).ThenByDescending(p => p.Age).ToList();

/*
 * select *
 * from people
 * order by name
*/

Console.WriteLine("Kolekcja posortowana:");
foreach (Person p in sortedPeople)
{
    Console.WriteLine($"Imię: {p.Name} Nazwisko: {p.Surname} Wiek: {p.Age}");
}

//if (people.Where(p => p.Age < 18).Count() > 0);

if(people.Any(p => p.Age < 18))
{
    Console.WriteLine("Są osoby niepełnoletnie");
}

if(people.All(p => p.Age >= 18))
{
    Console.WriteLine("Są osoby niepełnoletnie");
}

Person firstPerson = people.FirstOrDefault(p => p.Name.Length > 3);
//if (firstPerson != null) jeżęli firstPerson było by klasą
if (!firstPerson.Equals(default(Person))) // sprawdzanie dla typu wartościowego
{
    Console.WriteLine("Osoba z imieniem większym niż 3 litery ");
    Console.WriteLine($"{firstPerson.Name}");
}

//select name
//from poeple
//group by surname

var groupByName = people.GroupBy(p => p.Surname);
Console.WriteLine("pogrupowana kolekcja po nazwiskach:");
foreach(var group in groupByName)
{
    Console.WriteLine($"Nazwisko w grupie {group.Key} ");
}

//select surname, count(*),
//from poeple
//group by surname

var groupBySurname = people.GroupBy(p => p.Surname);
Console.WriteLine("pogrupowana kolekcja po nazwiskach:");
foreach (var group in groupBySurname)
{
    Console.WriteLine($"Nazwisko w grupie {group.Key} ");
    Console.WriteLine($"Ilość osób w grupie {group.Count()} ");
    Console.WriteLine($"Najstarsza osoba w grupie {group.Max(p => p.Age)} ");
    Console.WriteLine($"elementy grupy:");
    var sortGroup = group.OrderBy(group => group.Name);
    foreach(Person p in sortGroup)
    {
        Console.WriteLine($"Imię: {p.Name} Nazwisko: {p.Surname} Wiek: {p.Age}");
    }
}


Console.Clear();

/*
SELECT Name
FROM People
WHERE age >= 18
*/

List<string> names = people.Where(p => p.Age >= 18).Select(p => p.Name).ToList();