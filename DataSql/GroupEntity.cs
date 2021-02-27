using DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql
{
    public class GroupEntity : IGroup
    {
        public int Id { get; set; }
        public string NameGroup { get; set; }

        public GroupEntity() { }
        public GroupEntity(IGroup item)
        {
            Id = 0;
            NameGroup = item.NameGroup;
        }
    }
}
