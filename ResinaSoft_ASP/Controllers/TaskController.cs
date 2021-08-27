using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResinaSoft_ASP.Interfaces;
using ResinaSoft_ASP.Models;
using ResinaSoft_ASP.ViewModels.TaskViewModels;

namespace ResinaSoft_ASP.Controllers
{
    public class TaskController : Controller
    {
        // GET: TaskController
        private readonly IPersonTask _personTask;
        private IMapper _mapper;
        public TaskController(IPersonTask personTask, IMapper mapper)
        {
            _personTask = personTask;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            var model = _personTask.Task.GetAll();
            var vm = _mapper.Map<List<TaskViewModel>>(model);
            return View(vm);
        }

        public ActionResult PersonTasks(int personId)
        {
            return RedirectToAction("PersonToTask", "PersonTask", new { personId = personId });
        }


        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Persons()
        {
            return RedirectToAction("Index", "Person");
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskViewModel collection)
        {
            try
            {
                var model = _mapper.Map<Models.Task>(collection);
                _personTask.Task.Insert(model);
                _personTask.Save();
                return RedirectToAction("Index", "Task");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _personTask.Task.GetById(id);
            var vm = _mapper.Map<TaskViewModel>(model);
            return View(vm);
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TaskViewModel collection)
        {
            try
            {
                var model = _mapper.Map<Models.Task>(collection);
                _personTask.Task.Update(model);
                _personTask.Save();
                return RedirectToAction("Index", "Task");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _personTask.Task.GetById(id);
            _personTask.Task.Delete(model);
            _personTask.Save();
            return RedirectToAction("Index", "Task");
        }

        // POST: TaskController/Delete/5
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
