using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Employe
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? lastName { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
       
    }
}
