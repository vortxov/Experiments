using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll;

namespace DataSql.Tests
{
    [TestClass()]
    public class LaboratoryDataSqlTests
    {
        [TestMethod()]
        public void NewLaboratory_RemoveLaboratory()
        {
            var group = new Group()
            {
                NameGroup = "Group2"
            };

            var groupSql = new GroupDataSql();
            groupSql.Add(group);

            var experiment = new Experiment()
            {
                NameExperiment = "Experiment2"
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

            var laboratorylist = laboratorySql.ReadList();

            Assert.IsNotNull(laboratorylist);

            var laboratoryElement = laboratorySql.ReadList().SingleOrDefault(n => n.ExperimentId.Equals(experiment.Id) && 
                    n.GroupId.Equals(group.Id));

            Assert.IsNull(laboratoryElement);
        }

        
    }
}