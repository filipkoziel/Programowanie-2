using Microsoft.EntityFrameworkCore;
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
* 7 Dodaj wszystkim osobom 1 rok (symulacja urodzin).
* 8 Usuñ wszystkich, którzy maj¹ wiêcej ni¿ 80 lat.
* 9 ZnajdŸ najstarsz¹ osobê i zmieñ jej nazwisko na „Najstarszy”.
* 10 Usuñ osoby m³odsze ni¿ œrednia wieku.
* 11 Zmieñ imiona na wersjê „WIELKIMI LITERAMI”.


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
            return context.People.Count();
        }

        // 5 Zwróæ wszystkie unikalne imiona.

        public List<String> GetUniqueNames()
        {
            return context.People.Select(p => p.Name).Distinct().ToList();
        }

        //U - update

        public void UpdateName(int id, string newName)
        {
            Person? person = context.People.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                person.Name = newName;

                context.SaveChanges();
            }
        }

        // 6 Zmieñ nazwisko wszystkich osób o nazwisku „Kowalski” na „Kowal”.

        public void ChangeKowalskiSurnameToKowal()
        {
            Person? person = context.People.FirstOrDefault(p => p.Surname == "Kowalski");

            if (person != null)
            {
                person.Name = "Kowal";

                context.SaveChanges();
            }
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
    }
}