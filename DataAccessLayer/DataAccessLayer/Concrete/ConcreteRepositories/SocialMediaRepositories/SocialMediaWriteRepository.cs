using DataAccessLayer.Abstract.AbstractRepositories.SocialMediaRepositories;
using DataAccessLayer.Contexts;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.ConcreteRepositories.SocialMediaRepositories
{
    public class SocialMediaWriteRepository : WriteRepository<SocialMedia>, ISocialMediaWriteRepository
    {
        public SocialMediaWriteRepository(CoreDbContext context) : base(context)
        {
        }
    }
}
