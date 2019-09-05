using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockStatic
{

    public class EncryptionMediator
    {
        public IFakeSingnal _fake;
        public EncryptionMediator(IFakeSingnal fake = null)
        {
            this._fake = fake;
            //Encryption._fakeSignal = fake;
            //Utilities._fakeSignal = fake;

            FakeSignalManager.AddFakeSource(this._fake);

            
        }

        public void CleanSignalFake()
        {
            _fake = null;

            Encryption._fakeSignal = null;
            Utilities._fakeSignal = null;
        }

        public void DecryptFile(string s, string k)
        {
            Encryption.Decrypt(s, k);

            CleanSignalFake();
        }


        public void ReadBson(string s, string k, string b)
        {
            Encryption.Decrypt(s, k);

            Utilities.BsonToJson(b);

            CleanSignalFake();
        }
    }
}
