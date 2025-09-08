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
            if (!File.Exists(_filepath))
                throw new FileNotFoundException("Config file not found.", _filepath);

            var lines = File.ReadAllLines(_filepath)
                            .ToArray();

            if (lines.Length < 2)
                throw new InvalidDataException("Config file must contain at least two lines: name and connection string.");

            string name = lines[0].Trim();
            string connectionString = lines[1].Trim();

            return new ConfigFileParseResult(connectionString, name);
        }
    }
}
