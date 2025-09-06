using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Infrastructure.Mappers
{
    public abstract class BaseMapper
    {
        private readonly Dictionary<string, int> _ordinals = new Dictionary<string, int>();

        protected int Ordinal(IDataRecord record, string columnName)
        {
            if (_ordinals.TryGetValue(columnName, out var ordinalIndex))
                return ordinalIndex;

            ordinalIndex = record.GetOrdinal(columnName);
            _ordinals[columnName] = ordinalIndex;
            return ordinalIndex;
        }

        protected bool IsDbNull(IDataRecord record, string columnName)
        {
            var ordinalIndex = Ordinal(record, columnName);
            return record.IsDBNull(ordinalIndex);
        }

        protected string GetString(IDataRecord record, string columnName)
        {
            var ordinalINdex = Ordinal(record, columnName);
            return record.IsDBNull(ordinalINdex) ? string.Empty : record.GetString(ordinalINdex);
        }

        protected int GetInt(IDataRecord record, string columnName)
        {
            var ord = Ordinal(record, columnName);
            return record.IsDBNull(ord) ? 0 : record.GetInt32(ord);
        }

        protected decimal GetDecimal(IDataRecord record, string columnName)
        {
            var ord = Ordinal(record, columnName);
            return record.IsDBNull(ord) ? 0m : record.GetDecimal(ord);
        }

        protected DateTime GetDateTime(IDataRecord record, string columnName)
        {
            var ord = Ordinal(record, columnName);
            if (record.IsDBNull(ord))
                throw new InvalidOperationException($"Column {columnName} is NULL but expected a DateTime.");

            return record.GetDateTime(ord);
        }
    }
}
