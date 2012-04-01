using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SetTuples.Tests
{
    [TestClass]
    public class TupleTests
    {
        [TestMethod]
        public void GetDefaultValues()
        {
            Tuple tuple = new Tuple(2);

            Assert.IsNull(tuple[0]);
            Assert.IsNull(tuple[1]);
        }

        [TestMethod]
        public void SetAndGetValues()
        {
            Tuple tuple = new Tuple(2);

            tuple[0] = "Adam";
            tuple[1] = 800;

            Assert.AreEqual("Adam", tuple[0]);
            Assert.AreEqual(800, tuple[1]);
        }
    }
}
