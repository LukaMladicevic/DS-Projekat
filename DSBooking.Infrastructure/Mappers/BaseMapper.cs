using System;
using System.Data;

namespace DSBooking.Infrastructure.Mappers
{
    public abstract class BaseMapper
    {
        protected int Ordinal(IDataRecord record, string columnName)
        {
            // Always get ordinal from the current record to avoid stale indices
            return record.GetOrdinal(columnName);
        }

        protected bool IsDbNull(IDataRecord record, string columnName)
        {
            var ordinalIndex = Ordinal(record, columnName);
            return record.IsDBNull(ordinalIndex);
        }

        protected string GetString(IDataRecord record, string columnName)
        {
            var ordinalIndex = Ordinal(record, columnName);
            return record.IsDBNull(ordinalIndex) ? string.Empty : record.GetString(ordinalIndex);
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

            var val = record.GetValue(ord);
            return Convert.ToDateTime(val);
        }

        protected DateTime? GetDateTimeOrNull(IDataRecord record, string columnName)
        {
            var ord = Ordinal(record, columnName);
            return record.IsDBNull(ord) ? (DateTime?)null : record.GetDateTime(ord);
        }
    }
}
