using EntityLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities.Concrete
{
    public class Feature : BaseEntity
    {
        public string Header { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
