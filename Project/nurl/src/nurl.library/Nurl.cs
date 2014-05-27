using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace nurl.library
{
    public class Nurl : INurl
    {
        private WebClient wClient = new WebClient();

        public string Get(string url)
        {
            try
            {
                return this.wClient.DownloadString(url);
            }
            catch(ArgumentNullException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw;
            }
            catch(WebException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw;
            }
            catch(NotSupportedException ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public void GetAndSave(string url, string path)
        {
            throw new NotImplementedException();
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
