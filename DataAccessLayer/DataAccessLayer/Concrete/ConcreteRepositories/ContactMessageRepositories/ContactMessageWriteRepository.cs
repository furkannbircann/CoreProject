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
    public class ContactMessageWriteRepository : WriteRepository<ContactMessage>, IContactMessageWriteRepository
    {
        public ContactMessageWriteRepository(CoreDbContext context) : base(context)
        {
        }
    }
}
