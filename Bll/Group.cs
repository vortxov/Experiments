using DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Group : IGroup
    {
        public string NameGroup { get; set; }
        public int Id { get; set; }
    }
}
