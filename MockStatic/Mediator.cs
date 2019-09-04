using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockStatic
{

    public class EncryptionMediator
    {
        public IFake _fake;
        public EncryptionMediator(IFake fake = null)
        {
            this._fake = fake;
            if (fake != null)
            {
                Encryption._fake = fake;
                Utilities._fake = fake;
            }
        }

        public void CleanFake()
        {
            _fake = null;

            Encryption._fake = null;
            Utilities._fake = null;
        }

        public void DecryptFile(string s, string k)
        {
            Encryption.Decrypt(s, k);

            CleanFake();
        }


        public void ReadBson(string s, string k, string b)
        {
            Encryption.Decrypt(s, k);

            Utilities.BsonToJson(b);

            CleanFake();
        }
    }
}
