using DataAccessLayer.Abstract.AbstractRepositories.PortfolioRepositories;
using DataAccessLayer.Contexts;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.ConcreteRepositories.PortfolioRepositories
{
    public class PortfolioReadRepository : ReadRepository<Portfolio>, IPortfolioReadRepository
    {
        public PortfolioReadRepository(CoreDbContext context) : base(context)
        {
        }
    }
}
