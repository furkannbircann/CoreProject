using DataAccessLayer.Abstract.AbstractRepositories.ExperienceRepositories;
using DataAccessLayer.Contexts;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.ConcreteRepositories.ExperienceRepositories
{
    public class ExperienceReadRepository : ReadRepository<Experience>, IExperienceReadRepository
    {
        public ExperienceReadRepository(CoreDbContext context) : base(context)
        {
        }
    }
}
