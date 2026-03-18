using Microsoft.EntityFrameworkCore;
using PeopleTestClassLibrary.DTO_s;
using PeopleTestClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTestClassLibrary
{
    public class PeopleRepository
    {
        private PeopleDBContext context;

        public PeopleRepository()
        {
            context = new PeopleDBContext();
        }

        /*
*
* 
* 
* 
* 
* 
* 
* 


*/
        //C - create

        public void AddNewPerson(string name, string surname, int age)
        {
            Person newPerson = new Person() { Name = name, Surname = surname, Age = age };

            context.People.Add(newPerson);

            context.SaveChanges();
        }

        //R - Read

        public List<Person> GetAllPeople()
        {
            return context.People
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Surname)
                .ToList();
        }

        public List<PersonDTO> GetAllPeopleDTO()
        {
            return context.People
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Surname)
                .Select(p => new PersonDTO() { Id = p.Id, Name = p.Name, Surname = p.Surname, Age = p.Age })
                .ToList();
        }

        //1 Pobierz osoby o wieku wiêkszym ni¿ 30 lat.
        public List<Person> GetPeopleOver30()
        {
            return context.People
                .AsNoTracking()
                .Where(p=> p.Age < 30)
                .ToList();
        }

        //2 Pobierz osoby, których nazwisko zaczyna siê na „K”.

        public List<Person> GetPeopleWithNamesStartingWithK()
        {
            return context.People
                .AsNoTracking()
                .Where(p => p.Name[0] == 'K')
                .ToList();
        }

        //3 ZnajdŸ osoby z najmniejszym wiekiem.

        public List<Person> GetYoungestPeople()
        {
            int min = context.People.Min(p=> p.Age);
            return context.People
                .AsNoTracking()
                .Where(p=> p.Age == min)
                .ToList();
        }

        // 4 Policz, ile osób jest w tabeli.

        public int GetPeopleCount()
        {
            return context.People
                .AsNoTracking()
                .Count();
        }

        // 5 Zwróæ wszystkie unikalne imiona.

        public List<String> GetUniqueNamesList()
        {
            return context.People
                .AsNoTracking()
                .Select(p => p.Name)
                .Distinct()
                .ToList();
        }

        //U - update

        public void UpdatePerson(int id, string name, string surname, int age)
        {
            Person? person = context.People.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                person.Name = name;
                person.Surname = surname;
                person.Age = age;

                context.SaveChanges();
            }
        }

        public void UpdateName(int id, string newName)
        {
            Person? person = context.People.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                person.Name = newName;

                context.SaveChanges();
            }
        }

        public void UpdateSurname(int id, string newSurname)
        {
            Person? person = context.People.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                person.Surname = newSurname;

                context.SaveChanges();
            }
        }

        public void UpdateAge(int id, int newAge)
        {
            Person? person = context.People.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                person.Age = newAge;

                context.SaveChanges();
            }
        }

        // 6 Zmieñ nazwisko wszystkich osób o nazwisku „Kowalski” na „Kowal”.

        public void ChangeKowalskiSurnameToKowal()
        {
            List<Person> people = context.People.Where(p => p.Surname == "Kowalski").ToList();

            foreach(Person person in people)
            {
                person.Name = "Kowal";

                context.SaveChanges();
            }
        }

        //7 Dodaj wszystkim osobom 1 rok(symulacja urodzin).

        public void UpdateAge()
        {
            List<Person> people = context.People.ToList();

            foreach (Person person in people)
            {
                person.Age++;
            }

            context.SaveChanges();
        }

        //9 ZnajdŸ najstarsz¹ osobê i zmieñ jej nazwisko na „Najstarszy”.

        public void RenameOldest()
        {
            int max = context.People.Max(p => p.Age);
            Person? person = context.People.AsNoTracking().FirstOrDefault(p => p.Age == max);

            if (person != null)
            {
                person.Surname = "Najstarszy";

                context.SaveChanges();
            }
        }

        //11 Zmieñ imiona na wersjê „WIELKIMI LITERAMI”.

        public void CapitalizeNames()
        {
            List<Person> people = context.People.ToList();

            foreach (Person person in people)
            {
                person.Name = person.Name.ToUpper();
            }

            context.SaveChanges();
        }

        //D - delete

        public void DeletePerson(int id)
        {
            Person? person = context.People.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                context.People.Remove(person);
                context.SaveChanges();
            }

        }

        //8 Usuñ wszystkich, którzy maj¹ wiêcej ni¿ 80 lat.

        public void DeletePeopleOver80()
        {
            List<Person> persons = context.People.Where(p => p.Age > 80).ToList();

            foreach (Person person in persons)
            {
                context.People.Remove(person);
            }

            context.SaveChanges();
        }

        //10 Usuñ osoby m³odsze ni¿ œrednia wieku.

        public void DeletePeopleBelowAverageAge()
        {
            double averageAge = context.People.Average(p => p.Age);
            List<Person> persons = context.People.Where(p => p.Age < averageAge).ToList();

            foreach (Person person in persons)
            {
                context.People.Remove(person);
            }

            context.SaveChanges();
        }
    }
}