using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nurl.library;
using System.IO;

namespace nurl.test.NurlTest
{
    [TestClass]
    public class NurlGetTest
    {
        INurl nurl = new Nurl();
        string url = "B:/Etudes/ESGI/4AL2/Langage C#/CSharpProjectsExercices/Project/nurl/test/nurl.test/Pages/page1.html";
        [TestMethod]
        public void GetSuccessful()
        {
            Assert.AreEqual("<h1>Hello World</h1>", nurl.Get((url)));
        }

        [TestMethod]
        public void GetFailed()
        {
            Assert.AreNotEqual("Hello World</h1>", nurl.Get((url)));
        }
    }

    [TestClass]
    public class NurlGetAndSaveTest
    {
        INurl nurl = new Nurl();
        string url = "B:/Etudes/ESGI/4AL2/Langage C#/CSharpProjectsExercices/Project/nurl/test/nurl.test/Pages/page1.html";

        [TestMethod]
        public void GetAndSaveSuccessful()
        {
            var path = "success.txt";
            var expected = "<h1>Hello World</h1>";
            Assert.AreEqual(expected, nurl.GetAndSave(url, path));
            using(var file = File.OpenText(path))
            {
                var content = file.ReadToEnd();
                Assert.AreEqual(expected, content);
            }
        }

        [TestMethod]
        public void GetAndSaveFailed()
        {
            var path = "success.txt";
            var notExpected = "<h1>GoodB Bye</h1>";
            Assert.AreNotEqual(notExpected, nurl.GetAndSave(url, path));
            using (var file = File.OpenText(path))
            {
                var content = file.ReadToEnd();
                Assert.AreNotEqual(notExpected, content);
            }
        }
    }
}
