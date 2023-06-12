using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.AbstractRepositories.FeatureRepositories
{
    public interface IFeatureWriteRepository : IWriteRepository<Feature>
    {
    }
}
