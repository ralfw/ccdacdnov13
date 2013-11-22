using System;
using NUnit.Framework;

namespace servicewrappers.tests
{
    [TestFixture]
    public class test_HttpService
    {
        [Test, Explicit]
        public void Run()
        {
            using (var sut = new HttpService("samplehttpservice.exe", "", new Uri("http://localhost:1234")))
            {
                var result = sut.Process("hello-äöüÄÖÜß");
                Assert.AreEqual("<<<hello-äöüÄÖÜß>>>", result);
            }
        } 
    }
}