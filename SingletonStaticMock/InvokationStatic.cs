using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SingletonStaticMock
{

    public interface IInvokationStatic
    {
        ReturnType InvokePrivateStatic<ClassType, ReturnType>(string methodeName, object obj, params object[] parameters) where ClassType : class;
    }

    public class InvokationStatic :IInvokationStatic
    {
        private InvokationStatic()
        {

        }



        /// <summary>
        /// Invokes a method that its binding flag is set to private and static.
        /// </summary>
        /// <typeparam name="ClassType">The type of class in which the method is defined there.</typeparam>
        /// <typeparam name="ReturnType">The type of the result from the invoked method.</typeparam>
        /// <param name="methodeName"> The name of the private and generic method to be invoked. </param>
        /// <param name="obj">The object of the ClassType.</param>
        /// <param name="parameters"> The parameter of the method to be invoked. </param>
        /// <returns>Returns the result of the method.</returns>
        public ReturnType InvokePrivateStatic<ClassType, ReturnType>(string methodeName, object obj, params object[] parameters) where ClassType : class
        {
            var mi = typeof(ClassType).GetMethod(methodeName, BindingFlags.NonPublic | BindingFlags.Static);
            var result = mi.Invoke(obj, parameters);
            return (ReturnType)result;
        }
    }
}
