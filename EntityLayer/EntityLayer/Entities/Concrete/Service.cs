using EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities.Concrete
{
    public class Service : BaseEntity
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
