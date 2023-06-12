using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.AbstractRepositories.ContactRepositories
{
    public interface IContactWriteRepository : IWriteRepository<Contact>
    {
    }
}
