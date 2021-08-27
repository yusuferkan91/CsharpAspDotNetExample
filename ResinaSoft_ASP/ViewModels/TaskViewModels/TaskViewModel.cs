using ResinaSoft_ASP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.ViewModels.TaskViewModels
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
        public List<PersonTask> PersonTasks { get; set; }

    }
}
