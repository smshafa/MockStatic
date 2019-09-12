using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonStaticMock
{

    public class Mediator
    {
        private IInvokationStatic _fake;
        private Utilities _utilities;
        public Mediator(IInvokationStatic fake = null, Utilities utilities = null)
        {
            _fake = fake;
            _utilities = utilities;
        }

        public void DecryptFile(string s, string k)
        {
            Encryption.Decrypt(s, k);
        }

        public void ReadBsonFile(string file)
        {
            
            string s = _fake.InvokePrivateStatic<Utilities, string>("ReadBsonFile", this._utilities, file);
        }


        public void ReadBson(string s, string k, string b)
        {
            Encryption.Decrypt(s, k);

            Utilities.BsonToJson(b);
        }
    }
}
