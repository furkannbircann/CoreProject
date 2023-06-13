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
    public class FeatureWriteRepository : WriteRepository<Feature>, IFeatureWriteRepository
    {
        public FeatureWriteRepository(CoreDbContext context) : base(context)
        {

        }
    }
}
