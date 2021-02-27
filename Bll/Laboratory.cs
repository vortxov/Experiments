using DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Laboratory : ILaboratory
    {
        public int ExperimentId { get; set; }
        public int GroupId { get; set; }
        public DateTime DateTime { get; set; }
        public int Id { get; set; }
    }
}
