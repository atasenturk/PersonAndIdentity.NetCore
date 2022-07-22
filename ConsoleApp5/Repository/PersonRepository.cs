using ConsoleApp5.Contracts;
using ConsoleApp5.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        private readonly IdentityDBContext _context;

        public PersonRepository(IdentityDBContext context) : base(context)
        {
            this._context = context;
        }

        public PersonIdentity GetIdentityInfos(int ?id)
        {
            return _context.People.Include(q => q.PersonIdentities.Id == id).SingleOrDefault().PersonIdentities;
        }
    }
}
