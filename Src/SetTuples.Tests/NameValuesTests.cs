using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SetTuples.Tests
{
    [TestClass]
    public class NameValuesTests
    {
        [TestMethod]
        public void AddNameValues()
        {
            NameValues namevalues = new NameValues();

            namevalues.Add("Name", "Adam");
            namevalues.Add("Age", 800);

            Assert.IsNotNull(namevalues.Values);
            Assert.AreEqual(2, namevalues.Values.Count);
            Assert.AreEqual("Adam", namevalues.Values["Name"]);
            Assert.AreEqual(800, namevalues.Values["Age"]);
        }
    }
}
