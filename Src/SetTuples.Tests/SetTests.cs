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

        [TestMethod]
        public void AddTuple()
        {
            Column[] columns = new Column[] {
                new Column("Name", ColumnType.String),
                new Column("Age", ColumnType.Integer)
            };

            Set set = new Set(columns);

            NameValues values = new NameValues();
            values.Add("Name", "Adam");
            values.Add("Age", 800);

            var result = set.AddTuple(values);

            Assert.AreNotEqual(result, set);
            Assert.AreEqual(0, set.Tuples.Count());
            Assert.IsNotNull(result.Tuples);
            Assert.AreEqual(1, result.Tuples.Count());

            Tuple tuple = result.Tuples.First();
            Assert.AreEqual("Adam", tuple[0]);
            Assert.AreEqual(800, tuple[1]);
        }

        [TestMethod]
        public void AddColumns()
        {
            Column[] columns = new Column[] {
                new Column("Name", ColumnType.String),
                new Column("Age", ColumnType.Integer)
            };

            Set set = new Set(columns);

            NameValues values = new NameValues();
            values.Add("Name", "Adam");
            values.Add("Age", 800);

            set = set.AddTuple(values);

            Column[] newcolumns = new Column[] {
                new Column("Height", ColumnType.Integer),
                new Column("Weight", ColumnType.Integer)
            };

            var result = set.AddColumns(newcolumns);

            Assert.AreNotEqual(result, set);
            Assert.IsNotNull(result.Tuples);
            Assert.AreEqual(1, result.Tuples.Count());
            Assert.AreEqual(4, result.Columns.Count());

            Tuple tuple = result.Tuples.First();
            Assert.AreEqual("Adam", tuple[0]);
            Assert.AreEqual(800, tuple[1]);
            Assert.IsNull(tuple[2]);
            Assert.IsNull(tuple[3]);
        }
    }
}
