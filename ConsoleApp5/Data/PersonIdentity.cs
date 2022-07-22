using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp5.Data
{
    public class PersonIdentity
    {
        public int Id { get; set; }
        public string ?TCNo { get; set; }
        public string ?MaritalStat { get; set; }
        public string ?VolNum { get; set; }

        [ForeignKey(nameof(PersonId))]
        public int PersonId { get; set; }
        public Person ?Person { get; set; }
    }
}
