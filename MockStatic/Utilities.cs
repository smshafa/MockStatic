using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockStatic
{
    public class Utilities
    {
        public static IFake _fake;
        public static string BsonToJson(string B)
        {
            if (_fake != null)
                _fake.FakeCall();
            return "J";
        }
    }
}
