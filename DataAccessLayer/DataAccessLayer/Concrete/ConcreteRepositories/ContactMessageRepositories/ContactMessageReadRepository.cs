using DataAccessLayer.Abstract.AbstractRepositories.ContactMessageRepositories;
using DataAccessLayer.Contexts;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.ConcreteRepositories.ContactMessageRepositories
{
    public class ContactMessageReadRepository : ReadRepository<ContactMessage>, IContactMessageReadRepository
    {
        public ContactMessageReadRepository(CoreDbContext context) : base(context)
        {
        }
    }
}
