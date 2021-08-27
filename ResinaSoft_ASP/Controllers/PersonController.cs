using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResinaSoft_ASP.Interfaces;
using ResinaSoft_ASP.ViewModels.PersonViewModels;

namespace ResinaSoft_ASP.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonTask _personTask;
        private IMapper _mapper;
        public PersonController(IPersonTask personTask, IMapper mapper)
        {
            _personTask = personTask;
            _mapper = mapper;
        }
        // GET: PersonTask
        public ActionResult Index()
        {
            var model = _personTask.Person.GetAll();
            var vm = _mapper.Map<List<PersonViewModel>>(model);
            return View(vm);
        }


        // GET: PersonTask/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Tasks()
        {
            return RedirectToAction("Index", "Task");
        }

        // POST: PersonTask/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonViewModel collection)
        {
            try
            {
                var model = _mapper.Map<Models.Person>(collection);
                _personTask.Person.Insert(model);
                _personTask.Save();
                return RedirectToAction("Index", "Person");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: PersonTask/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _personTask.Person.GetById(id);
            var vm = _mapper.Map<PersonViewModel>(model);
            return View(vm);
        }

        // POST: PersonTask/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonViewModel collection)
        {
            try
            {
                var model = _mapper.Map<Models.Person>(collection);
                _personTask.Person.Update(model);
                _personTask.Save();
                return RedirectToAction("Index", "Person");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: PersonTask/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _personTask.Person.GetById(id);
            _personTask.Person.Delete(model);
            _personTask.Save();
            return RedirectToAction("Index", "Person");
        }

        // POST: PersonTask/Delete/5
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
