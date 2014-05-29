using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using nurl.library.Interface;

namespace nurl.library
{
    public class Nurl : INurl
    {
        private WebClient wClient = new WebClient();

        public string Get(string uri)
        {
            try
            {
                return this.wClient.DownloadString(uri);
            }
            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw;
            }
            catch (WebException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw;
            }
            catch (NotSupportedException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public void Save(string uri, string path)
        {
            try
            {

                wClient.DownloadFile(uri, path);
            }
            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw;
            }
            catch (WebException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw;
            }
            catch (NotSupportedException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<decimal> Test(string url, int n)
        {
            throw new NotImplementedException();
        }

        public decimal TestAvg(string url, int n)
        {
            throw new NotImplementedException();
        }
    }
}
