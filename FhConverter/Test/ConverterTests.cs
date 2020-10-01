using FhConverter.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FhConverter.Test
{
    [TestClass]
    public class ConverterTests
    {
        IConverter decToHexConverter = new DecToHexConverter();
        [TestMethod]
        public void Convert10_20_30()
        {
            var decs = new List<string> { "10", "28290", "156451" };
            var hexs = decToHexConverter.Convert(decs);

            Assert.AreEqual(new List<string>{ "A", "6E82", "26323" }, hexs);
        }
    }
}
