using DataAccessLayer.Abstract.AbstractRepositories.FeatureRepositories;
using DataAccessLayer.Contexts;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.ConcreteRepositories.FeatureRepositories
{
    public class FeatureReadRepository : ReadRepository<Feature>, IFeatureReadRepository
    {
        public FeatureReadRepository(CoreDbContext context) : base(context)
        {
        }
    }
}
