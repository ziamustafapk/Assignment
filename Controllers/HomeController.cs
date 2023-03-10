using Assignment.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.ViewModels;
using FluentValidation.Results;

namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonBusinessLogic _personBusinessLogic;

        public HomeController(IPersonBusinessLogic personBusinessLogic)
        {
            _personBusinessLogic = personBusinessLogic;
        }

        public ActionResult Index()
        {
            PersonViewModel personViewModel = new PersonViewModel();
            personViewModel.PersonViewModels = _personBusinessLogic.GetAllPersons().ToList();
            return View(personViewModel);
        }

        [HttpPost]
        public ActionResult AddPerson(PersonViewModel personViewModel)
        {
            
            PersonValidator validator = new PersonValidator();
            ValidationResult validationResult= validator.Validate(personViewModel);
            if (validationResult.IsValid)
            {
                var person = _personBusinessLogic.GetPersonByName(personViewModel.Name);

                if (person == null)
                {
                    var result = _personBusinessLogic.AddPerson(personViewModel);
                    personViewModel.Message = "User Added Successfully.";
                }
                else
                {
                    personViewModel.Email = person.Email;
                    personViewModel.Age = person.Age;
                    personViewModel.AlreadyExist = true;
                    personViewModel.Message = "User Already Exist.";
                } 
                    
            }
            else
            {
                foreach (ValidationFailure failer in validationResult.Errors)
                {
                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);
                }

            }
            personViewModel.PersonViewModels = _personBusinessLogic.GetAllPersons().ToList();

            return View("Index", personViewModel);
        }

        
        public ActionResult GetPersonByName(string name)
        {
            bool result = false;
            try
            {
                var person = _personBusinessLogic.GetPersonByName(name);
                if (person != null) result = true;
                return Json(new { result = result, person = person }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exception)
            {


                return Json(new { result = result }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}