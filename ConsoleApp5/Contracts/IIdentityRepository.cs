using ConsoleApp5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Contracts
{
    public interface IIdentityRepository : IGenericRepository<PersonIdentity>
    {
        Person GetPersonWithTC(string TC);

        bool IsTcValid(string TC);
    }
}
