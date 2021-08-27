using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Models
{
    public class PersonAddresses
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string AddressType { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
    }
}
