using ConsoleApp5.Contracts;
using ConsoleApp5.Data;
using ConsoleApp5.Repository;

namespace IdentityUnitTest
{
    public class UnitTest1
    {
        IdentityDBContext _context;
        IIdentityRepository repository;

        public UnitTest1()
        {
            _context = new IdentityDBContext();
            repository = new IdentityRepository(_context);
        }

        [Fact]
        public void GetPersonWithTC_Test()
        {

            var person = repository.GetPersonWithTC("11036785252");
            Assert.NotNull(person);
            Assert.Equal("Ata", person.Name);

        }

        [Fact]
        public void IsTCValid_Test()
        {
            bool flag = repository.IsTcValid("11036785252");
            Assert.True(flag);
        }
    }
}