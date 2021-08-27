using ResinaSoft_ASP.Models;
using ResinaSoft_ASP.ViewModels.PersonTaskViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;

namespace ResinaSoft_ASP.Interfaces
{
    public interface ITask
    {
        List<Task> GetAll();
        List<PersonTaskViewModel> GetAllPersonTasks(int personId);
        List<Task> GetAllPersonNoTasks(int personId);
        Task GetById(int Id);
        void Insert(Task task);
        void Update(Task task);
        void Delete(Task task);
    }
}
