using ResinaSoft_ASP.Interfaces;
using ResinaSoft_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Repostories
{
    public class PersonTaskRepo : IPersonTask
    {
        private readonly ResinaSoftDBContainer _context;
        private IPerson _personRepo;
        private ITask _taskRepo;
        public PersonTaskRepo(ResinaSoftDBContainer context)
        {
            _context = context;
        }
        public IPerson Person
        {
            get
            {
                return _personRepo = _personRepo ?? new PersonRepo(_context);
            }
        }
        public ITask Task
        {
            get
            {
                return _taskRepo = _taskRepo ?? new TaskRepo(_context);
            }
        }

        public void Delete(int taskId, int personId)
        {
            var model = GetPersonTask(taskId,personId);
            _context.PersonTask.Remove(model);
            Save();
        }

        public PersonTask GetPersonTask(int taskId, int personId)
        {
            return _context.PersonTask.Where(s => s.TaskID == taskId && s.PersonID == personId).FirstOrDefault();
        }

        public void Insert(PersonTask model)
        {
            _context.PersonTask.Add(model);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(PersonTask model)
        {
            _context.PersonTask.Update(model);
            Save();
        }
    }
}
