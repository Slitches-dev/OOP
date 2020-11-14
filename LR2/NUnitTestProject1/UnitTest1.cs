using NUnit.Framework;
using System;
using LR2;

namespace NUnitTestProject1
{
    public class Tests
    {
        DocumentWorker documentWorker;

        [Test]
        public void TestProDocumentWorker()
        {
            String keyPro = "123qwe";
            if (keyPro.Equals("342ewq"))
                documentWorker = new ProDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsFalse(documentWorker.GetType().Equals(typeof(ProDocumentWorker)));
        }

        [Test]
        public void TestProDocumentWorker2()
        {
            String keyPro = "342ewq";
            if (keyPro.Equals("342ewq"))
                documentWorker = new ProDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsTrue(documentWorker.GetType().Equals(typeof(ProDocumentWorker)));
        }

        [Test]
        public void TestProDocumentWorker3()
        {
            String keyPro = "342EWQ";
            if (keyPro.Equals("342ewq"))
                documentWorker = new ProDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsFalse(documentWorker.GetType().Equals(typeof(ProDocumentWorker)));
        }

        [Test]
        public void TestExpDocumentWorker()
        {
            String keyExp = "123qwe";
            if (keyExp.Equals("123qwe"))
                documentWorker = new ExpertDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsTrue(documentWorker.GetType().Equals(typeof(ExpertDocumentWorker)));
        }

        [Test]
        public void TestExpDocumentWorker2()
        {
            String keyExp = "weq321";
            if (keyExp.Equals("123qwe"))
                documentWorker = new ExpertDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsFalse(documentWorker.GetType().Equals(typeof(ExpertDocumentWorker)));
        }

        [Test]
        public void TestExpDocumentWorker3()
        {
            String keyExp = "123QWe";
            if (keyExp.Equals("123qwe"))
                documentWorker = new ExpertDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsFalse(documentWorker.GetType().Equals(typeof(ExpertDocumentWorker)));
        }

        [Test]
        public void TestDocumentWorker()
        {
            String keyExp = "123qwe";
            String keyPro = "321wq";
            if (keyExp.Equals("123qwe"))
                documentWorker = new ExpertDocumentWorker();
            else if (keyPro.Equals("342ewq"))
                documentWorker = new ProDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsTrue(documentWorker.GetType().Equals(typeof(ExpertDocumentWorker)));
        }

        [Test]
        public void TestDocumentWorker2()
        {
            String keyExp = "1254wqe";
            String keyPro = "342ewq";
            if (keyExp.Equals("123qwe"))
                documentWorker = new ExpertDocumentWorker();
            else if (keyPro.Equals("342ewq"))
                documentWorker = new ProDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsTrue(documentWorker.GetType().Equals(typeof(ProDocumentWorker)));
        }

        [Test]
        public void TestDocumentWorker3()
        {
            String keyExp = "";
            String keyPro = "";
            if (keyExp.Equals("123qwe"))
                documentWorker = new ExpertDocumentWorker();
            else if (keyPro.Equals("342ewq"))
                documentWorker = new ProDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsTrue(documentWorker.GetType().Equals(typeof(DocumentWorker)));
        }

        [Test]
        public void TestDocumentWorker4()
        {
            String keyExp = "123qwe";
            String keyPro = "342ewq";
            if (keyExp.Equals("123qwe"))
                documentWorker = new ExpertDocumentWorker();
            else if (keyPro.Equals("342ewq"))
                documentWorker = new ProDocumentWorker();
            else documentWorker = new DocumentWorker();
            Assert.IsTrue(documentWorker.GetType().Equals(typeof(ExpertDocumentWorker)));
        }
    }
}