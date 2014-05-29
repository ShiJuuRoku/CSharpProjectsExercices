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
        /// <param name="uri">uri of page.</param>
        /// <returns>Content page</returns>
        string Get(string uri);
        
        /// <summary>
        /// Save content page.
        /// </summary>
        /// <param name="uri">uri of page.</param>
        /// <param name="path">Path to save content page</param>
        void Save(string uri, string path);

        /// <summary>
        /// Test n times the time of loading and return these N times
        /// </summary>
        /// <param name="uri">uri of page.</param>
        /// <param name="n">Number of time it would be tested</param>
        /// <returns>IEnumerable<decimal> N times</returns>
        IEnumerable<decimal> Test(string uri, int n);

        /// <summary>
        /// Test n times the time of loading and return the average.
        /// </summary>
        /// <param name="uri">uri of page</param>
        /// <param name="n">Number of time it would be tested</param>
        /// <returns>decimal average</returns>
        decimal TestAvg(string uri, int n);
    }
}
