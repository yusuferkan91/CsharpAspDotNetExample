using ResinaSoft_ASP.Interfaces;
using ResinaSoft_ASP.Models;
using ResinaSoft_ASP.ViewModels.PersonTaskViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Repostories
{
    public class PersonRepo : IPerson
    {
        private readonly ResinaSoftDBContainer _context;
        public PersonRepo(ResinaSoftDBContainer context)
        {
            _context = context;
        }
        public void Delete(Person person)
        {
            _context.Persons.Remove(person);
        }

        public List<Person> GetAll()
        {
            return _context.Persons.ToList();
        }

        public List<Person> GetAllTaskNoPersons(int taskId)
        {
            var tp = _context.PersonTask.Where(s => s.TaskID == taskId);

            var persons = _context.Persons.Where(x => !tp.Any(a => a.PersonID == x.Id)).ToList();

            return persons;

        }

        public List<PersonTaskViewModel> GetAllTaskPersons(int taskId)
        {
            var ts = (from pt in _context.PersonTask
                      from p in _context.Persons
                      where p.Id == pt.PersonID
                      && pt.TaskID == taskId
                      select new PersonTaskViewModel
                      {
                          Person = pt.Person,
                          Task = pt.Task,
                          TaskStatus = pt.TaskStatus,
                          PersonID = pt.PersonID,
                          TaskID = pt.TaskID
                      });

            return ts.ToList();
        }

        public Person GetById(int Id)
        {
            return _context.Persons.FirstOrDefault(x => x.Id == Id);
        }

        public void Insert(Person person)
        {
            _context.Persons.Add(person);
        }

        public void Update(Person person)
        {
            _context.Persons.Update(person);
        }
    }
}
