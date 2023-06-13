using DataAccessLayer.Abstract.AbstractRepositories.AboutRepositories;
using DataAccessLayer.Contexts;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.ConcreteRepositories.AboutRepositories
{
    public class AboutReadRepository : ReadRepository<About> , IAboutReadRepository
    {
        public AboutReadRepository(CoreDbContext context) : base(context)
        {

        }
    }
}
