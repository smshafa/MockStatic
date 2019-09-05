using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockStatic;
using Moq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var encryption = new Mock<IFakeSingnal>();            
            encryption.Setup(_ => _.FakeSignalCall());


            EncryptionMediator mediator = new EncryptionMediator(encryption.Object);            
            mediator.DecryptFile("", "");

            encryption.Verify(_ => _.FakeSignalCall(), Times.Once());

        }


        [TestMethod]
        public void TestMethod2()
        {
            var encryption = new Mock<IFakeSingnal>();
            encryption.Setup(_ => _.FakeSignalCall());            



            EncryptionMediator mediator = new EncryptionMediator(encryption.Object);
            //mediator.DecryptFile("", "");
            mediator.ReadBson("", "", "");

            encryption.Verify(_ => _.FakeSignalCall(), Times.Exactly(2));            
        }
    }
}
