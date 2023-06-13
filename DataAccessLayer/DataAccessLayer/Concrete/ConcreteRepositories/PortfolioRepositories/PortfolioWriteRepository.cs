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
    public class PortfolioWriteRepository : WriteRepository<Portfolio>, IPortfolioWriteRepository
    {
        public PortfolioWriteRepository(CoreDbContext context) : base(context)
        {
        }
    }
}
