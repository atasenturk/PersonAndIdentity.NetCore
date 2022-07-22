using ConsoleApp5.Contracts;
using ConsoleApp5.Data;
using ConsoleApp5.Repository;

namespace UnitTest
{
    public class UnitTest1
    {
        IdentityDBContext _context;
        IPersonRepository repository;
        public UnitTest1()
        {
            _context = new IdentityDBContext();
            repository = new PersonRepository(_context);
        }
        [Fact]
        public void GetById_Test()
        {
            var person = repository.GetById(1);
            Assert.NotNull(person);
            Assert.Equal("Ata", person.Name);
        }

        [Fact]
        public void GetAll_Test()
        {
            var people = repository.GetAll();
            Assert.Equal(1, people.Count());
        }



    }
}