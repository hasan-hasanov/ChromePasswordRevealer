using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChromePasswordRevealer.Data.Extensions
{
    public static class DataExtensions
    {
        public static IEnumerable<T> Materialize<T>(this IDbCommand command, Func<IDataRecord, T> shaper)
        {
            using (IDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    yield return shaper(reader);
                }
            }
        }

        public static T Get<T>(this IDataRecord reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);

            return reader.IsDBNull(ordinal) ? default(T) : (T)reader.GetValue(ordinal);
        }
    }
}
