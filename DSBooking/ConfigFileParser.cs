using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSBooking.Infrastructure;

namespace DSBooking
{
    public class ConfigFileParser
    {
        string _filepath;

        public ConfigFileParser(string filepath)
        {
            _filepath = filepath;
        }

        public ConfigFileParseResult Parse()
        {
            // TODO
            return new ConfigFileParseResult ("a", "b");
        }
    }
}
