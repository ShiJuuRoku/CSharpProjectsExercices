using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using nurl.library.Interface;
using System.Diagnostics;

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

        public IEnumerable<long> Test(string uri, int n)
        {
            var sw = new Stopwatch();
            for(int i = 0; i<n; i++)
            {
                sw.Restart();
                Get(uri);
                sw.Stop();
                yield return sw.ElapsedMilliseconds;
            }
        }

        public long TestAvg(string url, int n)
        {
            return Test(url, n).AsParallel().Sum();
        }
    }
}
