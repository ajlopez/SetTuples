using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SetTuples.Tests
{
    [TestClass]
    public class ColumnTests
    {
        [TestMethod]
        public void CreateColumn()
        {
            Column column = new Column("Name", ColumnType.String);
            Assert.AreEqual("Name", column.Name);
            Assert.AreEqual(ColumnType.String, column.Type);
        }
    }
}
