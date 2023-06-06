using EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities.Concrete
{
    public class Portfolio : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
