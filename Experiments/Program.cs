using Bll;
using DataSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Group()
            {
                NameGroup = "Group1"
            };

            var groupSql = new GroupDataSql();
            groupSql.Add(group);

            var experiment = new Experiment()
            {
                NameExperiment = "Experiment1"
            };

            var experimentSql = new ExperimentDataSql();
            experimentSql.Add(experiment);


            var listGroup = groupSql.ReadList();
            var listExperiment = experimentSql.ReadList();

            var laboratory = new Laboratory()
            {
                ExperimentId = listExperiment.FirstOrDefault().Id,
                GroupId = listGroup.FirstOrDefault().Id
            };
            var laboratorySql = new LaboratoryDataSql();
            laboratorySql.Add(laboratory);
        }
    }
}
