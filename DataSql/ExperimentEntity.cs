using DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql
{
    public class ExperimentEntity : IExperiment
    {
        public int Id { get; set; }
        public string NameExperiment { get; set; }
        public ExperimentEntity() { }
        public ExperimentEntity(IExperiment item)
        {
            Id = 0;
            NameExperiment = item.NameExperiment;
        }
    }
}
