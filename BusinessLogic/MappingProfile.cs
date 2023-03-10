using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using Assignment.Models;
using Assignment.ViewModels;
using AutoMapper;

namespace Assignment.BusinessLogic
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
         
            CreateMap<Person, PersonViewModel>();
            CreateMap<PersonViewModel, Person>();
        }
    }
}