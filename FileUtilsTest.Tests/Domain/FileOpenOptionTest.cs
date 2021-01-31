using FileUtils.Domain.Entities.File;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FileUtilsTest.Tests.Domain
{
    [TestClass]
    public class FileOpenOptionTest
    {
        [TestMethod]
        public void 値の取得テスト()
        {
            FileOpenOption option = new FileOpenOption(System.IO.FileMode.Append, System.IO.FileAccess.Read);
            var mode = option.Mode;
            Assert.AreEqual(System.IO.FileMode.Append, mode);
        }
    }
}
