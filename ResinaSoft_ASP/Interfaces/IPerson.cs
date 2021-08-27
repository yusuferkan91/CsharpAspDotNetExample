using ResinaSoft_ASP.Models;
using ResinaSoft_ASP.ViewModels.PersonTaskViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Interfaces
{
    public interface IPerson
    {
        List<Person> GetAll();
        Person GetById(int Id);
        void Insert(Person person);
        void Update(Person person);
        void Delete(Person person);

        List<PersonTaskViewModel> GetAllTaskPersons(int taskId);
        List<Person> GetAllTaskNoPersons(int taskId);
    }
}
