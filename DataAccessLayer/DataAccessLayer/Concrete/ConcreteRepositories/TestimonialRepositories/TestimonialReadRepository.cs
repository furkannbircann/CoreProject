using DataAccessLayer.Abstract.AbstractRepositories.TestimonialRepositories;
using DataAccessLayer.Contexts;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.ConcreteRepositories.TestimonialRepositories
{
    public class TestimonialReadRepository : ReadRepository<Testimonial>, ITestimonialReadRepository
    {
        public TestimonialReadRepository(CoreDbContext context) : base(context)
        {
        }
    }
}
