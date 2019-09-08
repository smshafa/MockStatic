using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeSignalManagerFactory
{
    public static class Encryption
    {
        public static IFakeSingnal _decryptFakeSignal;
        public static string Decrypt(string t, string k)
        {
            bool flag = false;

            try
            {
                string decryptOperation = "throw";
                throw new Exception("Test Exception.");
                
            }
            
            catch(Exception ex)
            {
                flag = true;
                _decryptFakeSignal.FakeSignal();
                throw ex;
            }
            finally {
                //if (!flag)
                //    _decryptFakeSignal.FakeSignal(parameter, outputValue);
            }

            return "decrypted";
            //catch (Exception ex)
            //{
            //    _decryptFakeSignal.FakeSignal(ex);
            //    _decryptFakeSignal.IsFakeSingnal = true;
            //    throw new Exception("Test Exception.");
            //}
            //finally
            //{
            //    //if (!_decryptFakeSignal.IsFakeSingnal)
            //    //    _decryptFakeSignal.FakeSignal();
            //}

            //return "decrypted";
        }
    }
}
