using DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql
{
    public class GroupDataSql : IData<IGroup>
    {
        public void Add(IGroup item)
        {
            using (var db = new ExperimensContext())
            {
                var group = new GroupEntity(item);
                db.Groups.Add(group);
                db.SaveChanges();
            }
        }

        public IEnumerable<IGroup> ReadList()
        {
            using (var db = new ExperimensContext())
            {
                return db.Groups.ToList();
            }
        }

        public void Remove(IGroup item)
        {
            using (var db = new ExperimensContext())
            {
                var group = db.Groups.SingleOrDefault(n => n.NameGroup.Equals(item.NameGroup));
                db.Groups.Remove(group);
                db.SaveChanges();
            }
        }
    }
}
