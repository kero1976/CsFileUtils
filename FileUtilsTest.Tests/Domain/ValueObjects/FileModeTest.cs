using FileUtils.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FileUtilsTest.Tests.Domain.ValueObjects
{
    [TestClass]
    public class FileModeTest
    {
        [TestMethod]
        public void 日本語名の取得()
        {
            FileMode mode = new FileMode(1);
            var nameJ = mode.NameJ;
            Assert.AreEqual("CreateNew", nameJ);
        }
    }
}
