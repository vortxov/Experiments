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
    public class ExperimentDataSqlTests
    {
        [TestMethod()]
        public void NewExperiment_RemoveExperiment()
        {  
            var experiment = new Experiment()
            {
                NameExperiment = "Experiment"
            };

            var experimentSql = new ExperimentDataSql();
            
            experimentSql.Add(experiment);

            var listExperiment = experimentSql.ReadList();            

            Assert.IsNotNull(listExperiment);

            experimentSql.Remove(experiment);

            var experimentElement = experimentSql.ReadList().SingleOrDefault(n => n.NameExperiment.Equals(experiment.NameExperiment));

            Assert.IsNull(experimentElement);
        }


       
    }
}