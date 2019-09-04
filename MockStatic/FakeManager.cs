using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockStatic
{

    public interface IFakeManager
    {

    }

    public static class FakeManager
    {

        public static void AddFake(IFake fake)
        {
            Encryption._fake = fake;
            Utilities._fake = fake;
        }

        public static void Clean()
        {
            Encryption._fake = null;
            Utilities._fake = null;
        }
    }
}
