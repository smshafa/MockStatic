using System;

namespace FakeSignalManagerFactory
{
    public interface IFakeSignalFactory
    {

        IFakeSingnal EncryptionMethod { get; }
        IFakeSingnal BsonMethod { get; }
    }
}
