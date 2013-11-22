using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace servicewrappers.tests
{
    [TestFixture]
    public class test_ConsoleService
    {
        [Test, Explicit]
        public void Run()
        {
            var sut = new ConsoleService("sampleconsole.exe", "");

            var result = sut.Process("a\nb");
            Assert.AreEqual("<<<A\nB>>>\n", result);
        }
    }
}
