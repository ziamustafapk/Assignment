using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Data;
using Assignment.Models;
using Assignment.ViewModels;
using AutoMapper;
using AutoMapper.Internal;
using Microsoft.Ajax.Utilities;

namespace Assignment.BusinessLogic
{
    public class PersonBusinessLogic : IPersonBusinessLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonBusinessLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<PersonViewModel> GetAllPersons()
        {
            try
            {
                return
                    Mapper.Map<IEnumerable<Person>, IEnumerable<PersonViewModel>>
                        (_unitOfWork.Person.GetAllPersons());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
            
        }

        public PersonViewModel GetPersonByName(string name)
        {
            try
            {
                return
                    Mapper.Map<Person, PersonViewModel>
                        (_unitOfWork.Person.GetPersonByName(name));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
        }

        public PersonViewModel AddPerson(PersonViewModel personViewModel)
        {
            try
            {
                Person person = Mapper.Map<PersonViewModel, Person>(personViewModel);
                _unitOfWork.Person.AddPerson(person);
                return Mapper.Map<Person, PersonViewModel>(person);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
        }
    }
}