using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResinaSoft_ASP.Interfaces;
using ResinaSoft_ASP.ViewModels.AddressViewModel;

namespace ResinaSoft_ASP.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddress _address;
        private IMapper _mapper;
        public AddressController(IAddress address, IMapper mapper)
        {
            _address = address;
            _mapper = mapper;
        }
        // GET: PersonAddressesController
        public ActionResult Index(int personId)
        {
            if (personId > 0)
            { 
                ViewBag.PersonId = personId;
                var person = _address.GetPerson(personId);
                ViewBag.PersonName = person.Name + " " + person.LastName;
            }

            var model = _address.GetAll(personId);
            var vm = _mapper.Map<List<AddressViewModel>>(model);
            return View(vm);
        }

        // GET: PersonAddressesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonAddressesController/Create
        public ActionResult Create(int id)
        {
            var model = new AddressViewModel();
            ViewBag.PersonId = id;
            model.PersonId = id;
            return View(model);
        }

        // POST: PersonAddressesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressViewModel collection)
        {
            try
            {
                collection.Id = 0;
                var model = _mapper.Map<Models.PersonAddresses>(collection);
                _address.Insert(model);
                return RedirectToAction("Index", "Address", new { personId = model.PersonId });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: PersonAddressesController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _address.GetById(id);
            var vm = _mapper.Map<AddressViewModel>(model);
            return View(vm);
        }

        // POST: PersonAddressesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AddressViewModel collection)
        {
            try
            {
                var model = _mapper.Map<Models.PersonAddresses>(collection);
                _address.Update(model);
                _address.Save();
                return RedirectToAction("Index", "Address",new { personId = model.PersonId });
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: PersonAddressesController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _address.GetById(id);
            _address.Delete(model);
            _address.Save();
            return RedirectToAction("Index", "Address", new { personId = model.PersonId });
        }

        // POST: PersonAddressesController/Delete/5
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
