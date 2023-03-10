using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment.Data
{
    public class PersonRepository : IPersonRepository
    {
        static List<Person>  Persons = new List<Person>()
        {
            new Person { Name = "Zia", Age = 40, Email = "zia@live.com"},
            new Person{ Name = "Mick", Age = 30, Email = "mike@live.com"},
            new Person{ Name = "Amna", Age = 25, Email = "amna@live.com"}
            
        };

        #region Methods
        public IEnumerable<Person> GetAllPersons()
        {
            return Persons.ToList();
        }

        public Person GetPersonByName(string name)
        {
            return Persons.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
        }

        public Person AddPerson(Person person)
        {
            Persons.Add(person);
            return person;
        }

        #endregion


    }
}