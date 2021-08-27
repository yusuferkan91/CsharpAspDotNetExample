using AutoMapper;
using ResinaSoft_ASP.Models;
using ResinaSoft_ASP.ViewModels.AddressViewModel;
using ResinaSoft_ASP.ViewModels.PersonTaskViewModel;
using ResinaSoft_ASP.ViewModels.PersonViewModels;
using ResinaSoft_ASP.ViewModels.TaskViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;

namespace ResinaSoft_ASP.Helper
{
    public class Helper : Profile
    {
        public Helper()
        {
            CreateMap<Person, PersonViewModel>().ReverseMap();
            CreateMap<Task, TaskViewModel>().ReverseMap();
            CreateMap<PersonTask, PersonTaskViewModel>().ReverseMap();
            CreateMap<PersonAddresses, AddressViewModel>().ReverseMap();
        }
    }
}
