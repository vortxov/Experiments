using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public interface ILaboratory
    {
        int Id { get; set; }
        int ExperimentId { get; set; }
        int GroupId { get; set;}
        DateTime DateTime { get; set; }
    }
}
