using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace MyProject
{
    public class Book : AuditedEntity<Guid>
    {
        //public int _id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int[] MyProperty { get; set; }
    }
}
