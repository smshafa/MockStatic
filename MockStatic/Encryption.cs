using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockStatic
{
    public interface IFake
    {
        void FakeCall();
    }

    public class Fake : IFake
    {
        public void FakeCall()
        {

        }
    }

    public static class Encryption
    {
        public static IFake _fake;
        public static string Decrypt(string t, string k)
        {
            if (_fake != null)
                _fake.FakeCall();

            return "decrypted";
        }        
    }
}
