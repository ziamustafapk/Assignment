using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Models;

namespace Assignment.Data
{
    public interface IPersonRepository
    {
        #region Methods

        IEnumerable<Person> GetAllPersons();
        Person GetPersonByName(string name);
        Person AddPerson(Person person);

        #endregion

    }
}