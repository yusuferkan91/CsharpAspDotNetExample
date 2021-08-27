using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Interfaces
{
    public interface IEntity<T> where T : class
    {
        List<T> GetAll();
        T GetById(int Id);
        void Insert(T person);
        void Update(T person);
        void Delete(T person);
    }
}
