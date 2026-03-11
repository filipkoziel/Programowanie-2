using PeopleTestClassLibrary;
using PeopleTestClassLibrary.Models;

void writeAllPeople(List<Person> people ,string message)
{
    Console.WriteLine(message);
    foreach (Person person in people)
    {
        Console.WriteLine($"{person.Id} {person.Name} {person.Surname} lat {person.Age}");
    }
}


PeopleRepository peopleRepository = new PeopleRepository();

 