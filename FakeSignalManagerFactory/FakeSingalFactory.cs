using System;
using System.Collections.Generic;
using System.Text;

namespace FakeSignalManagerFactory
{
    public class FakeSingalFactory : IFakeSignalFactory
    {
        public FakeSingalFactory()
        {
            this.EncryptionMethod = new MockFakeSignal();
            this.BsonMethod = new MockFakeSignal();
        }
        public virtual IFakeSingnal EncryptionMethod { get; private set; }

        public virtual IFakeSingnal BsonMethod { get; private set; }
    }
}
