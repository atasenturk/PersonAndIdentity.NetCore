using ConsoleApp5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Contracts
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        public PersonIdentity GetIdentityInfos(int ?id);
    }
}
