using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockStatic
{

    public interface IFakeSignalManager
    {

    }

    public static class FakeSignalManager
    {

        public static void AddFakeSource(IFakeSingnal fake)
        {
            Encryption._fakeSignal = fake;
            Utilities._fakeSignal = fake;
        }

        public static void CleanFakeSignal()
        {
            Encryption._fakeSignal = null;
            Utilities._fakeSignal = null;
        }
    }
}
