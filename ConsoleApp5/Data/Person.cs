using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public string ?Surname { get; set; }
        public string ?Address { get; set; }
        public PersonIdentity ?PersonIdentities { get; set; }
    }
}
