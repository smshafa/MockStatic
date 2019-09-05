using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockStatic
{
    public class Utilities
    {
        public static IFakeSingnal _fakeSignal;
        public static string BsonToJson(string B)
        {
            if (_fakeSignal != null)
                _fakeSignal.FakeSignalCall();
            return "J";
        }
    }
}
