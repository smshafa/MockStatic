using Moq;
using SingletonStaticMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestProject
{
    public class UnitTest3
    {
        [Fact]
        public void Static_Test()
        {
            var invokationStatic = new Mock<IInvokationStatic>();

            Utilities utilities = new Utilities();
            invokationStatic.SetupAllProperties();
            invokationStatic.Setup(_ => _.InvokePrivateStatic<Utilities, string>("ReadBsonFile", utilities, It.IsAny<string>())).Returns(It.IsAny<string>());


            Mediator mediator = new Mediator(invokationStatic.Object, utilities);
            mediator.ReadBsonFile("sss");


            invokationStatic.Verify(_ => _.InvokePrivateStatic<Utilities, string>("ReadBsonFile", utilities, It.IsAny<string>()));

        }


        [Fact]
        public void Throw_Static_Test()
        {
            var invokationStatic = new Mock<IInvokationStatic>();

            Utilities utilities = new Utilities();
            invokationStatic.SetupAllProperties();
            invokationStatic.Setup(_ => _.InvokePrivateStatic<Utilities, string>("ReadBsonFile", utilities, It.IsAny<string>())).Returns(It.IsAny<string>());


            Mediator mediator = new Mediator(invokationStatic.Object, utilities);

            Action action = new Action(() => { mediator.ReadBsonFile("B"); });


            //invokationStatic.Verify(_ => _.InvokePrivateStatic<Utilities, string>("ReadBsonFile", utilities, It.IsAny<string>()));
            Assert.ThrowsAny<Exception>(action);
        }
    }
}
