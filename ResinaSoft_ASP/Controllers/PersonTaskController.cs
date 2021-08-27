using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResinaSoft_ASP.Interfaces;
using ResinaSoft_ASP.Models;
using ResinaSoft_ASP.ViewModels.PersonTaskViewModel;
using ResinaSoft_ASP.ViewModels.PersonViewModels;
using ResinaSoft_ASP.ViewModels.TaskViewModels;

namespace ResinaSoft_ASP.Controllers
{
    public class PersonTaskController : Controller
    {
        private readonly IPersonTask _personTask;
        private IMapper _mapper;
        private int _personId;
        public PersonTaskController(IPersonTask personTask, IMapper mapper)
        {
            _personTask = personTask;
            _mapper = mapper;
        }
        // GET: PersonTaskController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PersonToTask(int personId)
        {
            var vm = _personTask.Task.GetAllPersonTasks(personId);

            if(personId != 0)
            {
                ViewBag.PersonId = personId;
                var p = _personTask.Person.GetById(personId);
                ViewBag.PersonName = p.Name + " " + p.LastName;
            }

            return View(vm);
        }

        public ActionResult TaskToPerson(int taskId)
        {
            var vm = _personTask.Person.GetAllTaskPersons(taskId);

            if (taskId != 0)
            {
                ViewBag.TaskId = taskId;
                var t = _personTask.Task.GetById(taskId);
                ViewBag.TaskName = t.Name;
            }

            return View(vm);
        }
        public ActionResult AddToPerson(int taskId, int personId)
        {
            var p = _personTask.Person.GetById(personId);
            var t = _personTask.Task.GetById(taskId);
            var pt = new PersonTaskViewModel { Person = p, Task = t, PersonID = p.Id, TaskID = t.Id, TaskStatus = "Started"};
            var model = _mapper.Map<Models.PersonTask>(pt);

            _personTask.Insert(model);
            return RedirectToAction("PersonToTask", "PersonTask", new { personId = model.PersonID });
        }

        public ActionResult AddToTask(int personId,int taskId)
        {
            var p = _personTask.Person.GetById(personId);
            var t = _personTask.Task.GetById(taskId);
            var pt = new PersonTaskViewModel { Person = p, Task = t, PersonID = p.Id, TaskID = t.Id, TaskStatus = "Started" };
            var model = _mapper.Map<Models.PersonTask>(pt);

            _personTask.Insert(model);
            return RedirectToAction("TaskToPerson", "PersonTask", new { taskId = model.TaskID });
        }
        public ActionResult AddTask(int personId)
        {
            var model = _personTask.Task.GetAllPersonNoTasks(personId);
            ViewBag.personId = personId;
            var vm = _mapper.Map<List<TaskViewModel>>(model);
            return View(vm);
        }

        public ActionResult AddPerson(int taskId)
        {
            var model = _personTask.Person.GetAllTaskNoPersons(taskId);
            ViewBag.TaskId = taskId;
            var vm = _mapper.Map<List<PersonViewModel>>(model);
            return View(vm);
        }
        // GET: PersonTaskController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonTaskController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonTaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonTaskController/Edit/5
        public ActionResult Edit(int taskId, int personId)
        {
            var model = _personTask.GetPersonTask(taskId, personId);
            var person = _personTask.Person.GetById(personId);
            var task = _personTask.Task.GetById(taskId);
            model.Person = person;
            model.Task = task;
            var vm = _mapper.Map<PersonTaskViewModel>(model);
            return View(vm);
        }

        // POST: PersonTaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonTaskViewModel collection)
        {
            try
            {
                var pt = _mapper.Map<PersonTask>(collection);
                var model = _personTask.GetPersonTask(collection.TaskID, collection.PersonID);

                model.TaskStatus = collection.TaskStatus;
                _personTask.Update(model);
            }
            catch
            {
                return View();
            }
            return RedirectToAction("PersonToTask", "PersonTask", new { personId = collection.PersonID });
        }

        // GET: PersonTaskController/Delete/5
        public ActionResult Delete(int taskId, int personId)
        {
            _personTask.Delete(taskId, personId);
            return RedirectToAction("PersonToTask", "PersonTask", new { personId = personId });
        }

        public ActionResult DeletePerson(int taskId, int personId)
        {
            _personTask.Delete(taskId, personId);
            return RedirectToAction("TaskToPerson", "PersonTask", new { taskId = taskId });
        }
        // POST: PersonTaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
