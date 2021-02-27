using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSql
{
    public class ExperimensContext : DbContext
    {
        internal ExperimensContext() : base("Experimens") { }

        public DbSet<ExperimentEntity> Experiments { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<LaboratoryEntity> Laboratory { get; set; }
    }
}
