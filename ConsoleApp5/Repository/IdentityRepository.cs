using ConsoleApp5.Contracts;
using ConsoleApp5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Repository
{
    public class IdentityRepository : GenericRepository<PersonIdentity>, IIdentityRepository
    {
        private readonly IdentityDBContext context;

        public IdentityRepository(IdentityDBContext context) : base(context)
        {
            this.context = context;
        }

        public Person GetPersonWithTC(string TC)
        {
            int PersonId = context.Identities.Where(q => q.TCNo == TC).SingleOrDefault().PersonId;
            return context.People.Where(q => q.Id == PersonId).FirstOrDefault();
        }

        public bool IsTcValid(string TC)
        {
            return context.Identities.Where(q => q.TCNo == TC).Any();
        }
    }
}
