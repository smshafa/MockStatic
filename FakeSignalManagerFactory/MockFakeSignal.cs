using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeSignalManagerFactory
{
    public class MockFakeSignal : IFakeSingnal
    {
        public bool IsFakeSingnal { get; set; }
        public void FakeSignal(Exception exception = null)
        {
            if (exception != null)
                throw exception;
        }
    }
}
