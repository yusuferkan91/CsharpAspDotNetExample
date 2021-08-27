using ResinaSoft_ASP.Interfaces;
using ResinaSoft_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Repostories
{
    public class AddressRepo : IAddress
    {
        private readonly ResinaSoftDBContainer _context;

        public AddressRepo(ResinaSoftDBContainer context)
        {
            _context = context;
        }
        public void Delete(PersonAddresses address)
        {
            _context.PersonAddresses.Remove(address);
            Save();
        }
        public Person GetPerson(int personId)
        {
            return _context.Persons.FirstOrDefault(x => x.Id == personId);
        }
        public List<PersonAddresses> GetAll(int personId)
        {
            return _context.PersonAddresses.Where(s=>s.PersonId == personId).ToList();
        }
        public PersonAddresses GetById(int Id)
        {
            return _context.PersonAddresses.FirstOrDefault(x => x.Id == Id);
        }

        public void Insert(PersonAddresses address)
        {
            _context.PersonAddresses.Add(address);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(PersonAddresses address)
        {
            _context.PersonAddresses.Update(address);
            Save();
        }
    }
}
