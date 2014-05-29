using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using nurl.library.Interface;

namespace nurl.library
{

    public class NurlCommand : INurlCommand
    {
        public void Parse(string[] args)
        {
            if (args == null)
                throw new ArgumentNullException("Args is null.");
            if(args.Count() == 0)
                throw new ArgumentException("Args is empty.");
            switch(args[0].ToLower())
            {
                case "get":
                    ExecuteGet(args);
                    break;
                case "test":
                    break;
                default:
                    throw new ArgumentException("Command {0} not found : ", args[0]);
            }
        }

        public void ExecuteGet(string[] args)
        {
            if(args.Contains("-url", StringComparer.OrdinalIgnoreCase))
            {
                
            }
        }

        public void GetExecuteTest()
        {

        }

        public void Save(string content, string path)
        {
            throw new NotImplementedException();
        }

    }
}
