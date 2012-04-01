using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SetTuples.Tests
{
    [TestClass]
    public class SetTests
    {
        [TestMethod]
        public void CreateSet()
        {
            Column[] columns = new Column[] {
                new Column("Name", ColumnType.String),
                new Column("Age", ColumnType.Integer)
            };

            Set set = new Set(columns);

            Assert.IsNotNull(set.Tuples);
            Assert.AreEqual(0, set.Tuples.Count());

            Assert.IsNotNull(set.Columns);
            Assert.AreEqual(2, set.Columns.Count());
            Assert.AreEqual("Name", set.Columns.First().Name);
            Assert.AreEqual("Age", set.Columns.Skip(1).First().Name);
        }
    }
}
