using EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities.Concrete
{
    public class Skill : BaseEntity
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }
}
