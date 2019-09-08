using FakeSignalManagerFactory;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject
{
    public class UnitTest2
    {

        [Fact]
        public void TestMethod2()
        {
            bool flag = true ;
            var fakeSingnalMock = new Mock<FakeSingalFactory>();
            fakeSingnalMock.SetupAllProperties();
            //fakeSingnalMock.Setup(_ => _.EncryptionMethod.IsFakeSingnal).Callback<bool>(value => flag = value).Returns(flag);
            fakeSingnalMock.Setup(_ => _.EncryptionMethod.FakeSignal(It.IsAny<Exception>()));
            fakeSingnalMock.Setup(_ => _.BsonMethod.FakeSignal(It.IsAny<Exception>()));



            EncryptionMediator mediator = new EncryptionMediator(fakeSingnalMock.Object);

            Action empty = () => { mediator.ReadBson("", "", ""); };
            empty.Invoke();

            //fakeSingnalMock.Verify(_ => _.EncryptionMethod.FakeSignal(It.IsAny<Exception>()), Times.AtLeastOnce);
            //fakeSingnalMock.Verify(_ => _.BsonMethod.FakeSignal(It.IsAny<Exception>()), Times.AtLeastOnce);

            
            Xunit.Assert.ThrowsAny<Exception>(empty);
        }
    }
}
