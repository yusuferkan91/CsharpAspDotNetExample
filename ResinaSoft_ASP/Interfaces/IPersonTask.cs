using ResinaSoft_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Interfaces
{
    public interface IPersonTask
    {
        IPerson Person { get; }
        ITask Task { get; }
        void Save();

        void Insert(PersonTask model);
        void Update(PersonTask model);
        void Delete(int taskId, int personId);
        PersonTask GetPersonTask(int taskId, int personId);
    }
}
