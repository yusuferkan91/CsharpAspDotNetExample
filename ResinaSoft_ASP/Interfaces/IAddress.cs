using ResinaSoft_ASP.Models;
using System.Collections.Generic;

namespace ResinaSoft_ASP.Interfaces
{
    public interface IAddress
    {
        List<PersonAddresses> GetAll(int personId);
        PersonAddresses GetById(int Id);
        Person GetPerson(int personId);
        void Insert(PersonAddresses address);
        void Update(PersonAddresses address);
        void Delete(PersonAddresses address);
        void Save();
    }
}
