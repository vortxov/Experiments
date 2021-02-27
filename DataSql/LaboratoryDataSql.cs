using DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql
{
    public class LaboratoryDataSql : IData<ILaboratory>
    {
        public void Add(ILaboratory item)
        {
            using (var db = new ExperimensContext())
            {
                var laboratory = new LaboratoryEntity(item);
                db.Laboratory.Add(laboratory);
                db.SaveChanges();
            }
        }

        public IEnumerable<ILaboratory> ReadList()
        {
            using (var db = new ExperimensContext())
            {
                return db.Laboratory.ToList();
            }
        }

        public void Remove(ILaboratory item)
        {
            using (var db = new ExperimensContext())
            {
                var laboratory = db.Laboratory.SingleOrDefault(n => n.ExperimentId.Equals(item.ExperimentId) &&
                    n.GroupId.Equals(item.GroupId) &&
                    n.DateTime.Equals(item.DateTime));
                db.Laboratory.Remove(laboratory);
                db.SaveChanges();
            }
        }
    }
}
