using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeSignalManagerFactory
{
    public class Utilities
    {
        public static IFakeSingnal _BsonFakeSignal;
        public static string BsonToJson(string B)
        {
            try
            {
                string bsonOperation = "operation";
            }
            catch (Exception ex)
            {
                _BsonFakeSignal.FakeSignal(ex);
                _BsonFakeSignal.IsFakeSingnal = true;
            }
            finally
            {
                if (!_BsonFakeSignal.IsFakeSingnal)
                    _BsonFakeSignal.FakeSignal();
            }
            return "J";
        }
    }
}
