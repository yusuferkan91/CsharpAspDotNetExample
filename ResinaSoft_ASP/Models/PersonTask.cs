using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Models
{
    public class PersonTask
    {
        public int PersonID { get; set; }
        
        public int TaskID { get; set; }
        public string TaskStatus { get; set; }
        public Person Person { get; set; }
        public Task Task { get; set; }
    }
}
