using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nurl.library
{
    public interface INurl
    {
        /// <summary>
        /// Download a web page.
        /// </summary>
        /// <param name="url">Url of page.</param>
        /// <returns>Content page</returns>
        string Get(string url);
        
        /// <summary>
        /// Download a web page and save it.
        /// </summary>
        /// <param name="url">Url of page.</param>
        /// <param name="path">Path to save content page</param>
        /// <returns>Content page</returns>
        string GetAndSave(string url, string path);

        /// <summary>
        /// Test n times the time of loading and return these N times
        /// </summary>
        /// <param name="url">Url of page.</param>
        /// <param name="n">Number of time it would be tested</param>
        /// <returns>IEnumerable<decimal> N times</returns>
        IEnumerable<decimal> Test(string url, int n);

        /// <summary>
        /// Test n times the time of loading and return the average.
        /// </summary>
        /// <param name="url">Url of page</param>
        /// <param name="n">Number of time it would be tested</param>
        /// <returns>decimal average</returns>
        decimal TestAvg(string url, int n);
    }
}
