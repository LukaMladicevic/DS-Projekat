using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking
{
    public class ConfigFileParseResult
    {
        public string ConnectionString { get; }
        public string Name { get; }

        public ConfigFileParseResult(string connectionString, string name)
        {
            ConnectionString = connectionString;
            Name = name;
        }
    }
}
