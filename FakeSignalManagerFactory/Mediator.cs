using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeSignalManagerFactory
{

    public class EncryptionMediator
    {
        public IFakeSingnal _fake;
        public EncryptionMediator(IFakeSignalFactory fake = null)
        {
            Encryption._decryptFakeSignal = fake.EncryptionMethod;
            Utilities._BsonFakeSignal = fake.BsonMethod;
        }

        public void DecryptFile(string s, string k)
        {
            Encryption.Decrypt(s, k);
        }


        public void ReadBson(string s, string k, string b)
        {
            try
            { 

                Encryption.Decrypt(s, k);

                Utilities.BsonToJson(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
