using DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql
{
    public class ExperimentDataSql : IData<IExperiment>
    {
        public void Add(IExperiment item)
        {
            using (var db = new ExperimensContext())
            {
                var experiment = new ExperimentEntity(item);
                db.Experiments.Add(experiment);
                db.SaveChanges();
            }
        }

        public IEnumerable<IExperiment> ReadList()
        {
            using (var db = new ExperimensContext())
            {
                return db.Experiments.ToList();
            }
        }

        public void Remove(IExperiment item)
        {
            using (var db = new ExperimensContext())
            {
                var experiment = db.Experiments.FirstOrDefault(n => n.NameExperiment.Equals(item.NameExperiment));
                db.Experiments.Remove(experiment);
                db.SaveChanges();
            }
        }
    }
}
