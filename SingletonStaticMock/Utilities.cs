using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonStaticMock
{
    public class Utilities
    {
        public static string BsonToJson(string B)
        {
            if (B == "throw")
                throw new Exception("test");

            return "J";
            
        }
    }
}
