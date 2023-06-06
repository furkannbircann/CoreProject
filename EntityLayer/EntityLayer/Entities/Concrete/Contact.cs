using EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities.Concrete
{
    public class Contact : BaseEntity
    {
        public string Title { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
