using ResinaSoft_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.ViewModels.PersonTaskViewModel
{
    public class PersonTaskViewModel
    {
        public int PersonID { get; set; }

        public int TaskID { get; set; }
        public string TaskStatus { get; set; }
        public Person Person { get; set; }
        public Models.Task Task { get; set; }
    }
}
