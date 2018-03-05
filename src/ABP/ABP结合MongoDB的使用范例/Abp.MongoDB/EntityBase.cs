using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp
{
    /// <summary>
    /// 继承基础参数
    /// </summary>
    public class EntityBase
    {
        public string id { get; set; }
        public DateTime createDate { get; set; }
    }
}
