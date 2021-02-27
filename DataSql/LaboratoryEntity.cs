using DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql
{
    public class LaboratoryEntity : ILaboratory
    {
        public int Id { get; set; }
        public int ExperimentId { get; set; }
        public int GroupId { get; set; }
        public DateTime DateTime { get; set; }

        public LaboratoryEntity() { }
        public LaboratoryEntity(ILaboratory laboratory)
        {
            Id = 0;
            ExperimentId = laboratory.ExperimentId;
            GroupId = laboratory.GroupId;
            DateTime = DateTime.Now;
        }
    }
}
