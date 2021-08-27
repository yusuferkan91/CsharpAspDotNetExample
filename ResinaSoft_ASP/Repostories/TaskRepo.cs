using ResinaSoft_ASP.Interfaces;
using ResinaSoft_ASP.Models;
using ResinaSoft_ASP.ViewModels.PersonTaskViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Repostories
{
    public class TaskRepo : ITask
    {
        private readonly ResinaSoftDBContainer _context;
        public TaskRepo(ResinaSoftDBContainer context)
        {
            _context = context;
        }
        public void Delete(Models.Task task)
        {
            _context.Tasks.Remove(task);
        }

        public List<Models.Task> GetAll()
        {
            return _context.Tasks.ToList();
        }
        public List<PersonTaskViewModel> GetAllPersonTasks(int personId)
        {
            var ts = (from pt in _context.PersonTask
                      from t in _context.Tasks
                      where t.Id == pt.TaskID
                      && pt.PersonID == personId
                      select new PersonTaskViewModel { 
                          //Id = pt.Id,
                          Person = pt.Person,
                          Task = pt.Task,
                          TaskStatus = pt.TaskStatus,
                          PersonID = pt.PersonID,
                          TaskID = pt.TaskID
                      });

            return ts.ToList();
        }
        public List<Models.Task> GetAllPersonNoTasks(int personId)
        {
            //select* from Tasks where Id not in (select TaskID from PersonTask where PersonID = 1)

            var tp = _context.PersonTask.Where(s => s.PersonID == personId);

            var tasks = _context.Tasks.Where(x => !tp.Any(a=>a.TaskID == x.Id)).ToList();

            return tasks;
        }
        public Models.Task GetById(int Id)
        {
            return _context.Tasks.FirstOrDefault(x => x.Id == Id);
        }

        public void Insert(Models.Task task)
        {
            _context.Tasks.Add(task);
        }

        public void Update(Models.Task task)
        {
            _context.Tasks.Update(task);
        }
    }
}
