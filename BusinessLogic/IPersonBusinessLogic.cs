using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.ViewModels;

namespace Assignment.BusinessLogic
{
    public interface IPersonBusinessLogic
    {
        #region CustomMethods

        IEnumerable<PersonViewModel> GetAllPersons();
        PersonViewModel GetPersonByName(string name);
        PersonViewModel AddPerson(PersonViewModel personViewModel);

        #endregion
    }
}