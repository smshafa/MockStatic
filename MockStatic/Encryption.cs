using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockStatic
{
    public static class Encryption
    {
        public static IFakeSingnal _fakeSignal;
        public static string Decrypt(string t, string k)
        {
            if (_fakeSignal != null)
                _fakeSignal.FakeSignalCall();

            return "decrypted";
        }        
    }
}
