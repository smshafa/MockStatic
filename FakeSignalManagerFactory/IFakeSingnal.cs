using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeSignalManagerFactory
{
    public interface IFakeSingnal
    {
        bool IsFakeSingnal { get; set; }
        void FakeSignal(Exception exception = null);
    }
}
