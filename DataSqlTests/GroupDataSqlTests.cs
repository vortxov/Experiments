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
    public class GroupDataSqlTests
    {
        [TestMethod()]
        public void NewGroup_RemoveGroup()
        {
            var group = new Group()
            {
                NameGroup = "Group"
            };

            var groupSql = new GroupDataSql();
            groupSql.Add(group);

            var listGroup= groupSql.ReadList();

            Assert.IsNotNull(listGroup);

            groupSql.Remove(group);

            var groupElement = groupSql.ReadList().SingleOrDefault(n => n.NameGroup.Equals(group.NameGroup));

            Assert.IsNull(groupElement);
        }

       
    }
}