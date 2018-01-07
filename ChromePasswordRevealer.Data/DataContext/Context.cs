using ChromePasswordRevealer.Data.Connection_String.Abstract;
using ChromePasswordRevealer.Data.DataContext.Abstract;
using ChromePasswordRevealer.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ChromePasswordRevealer.Data.DataContext
{
    public class Context : IContext
    {
        private readonly IConnectionString _connectionString;

        public Context(IConnectionString connectionString)
        {
            this._connectionString = connectionString;
        }

        public List<T> ExecuteQuery<T>(string query, Func<IDataRecord, T> materializeTable)
        {
            using (SQLiteConnection sqLite = new SQLiteConnection(_connectionString.GetConnectionString()))
            {
                sqLite.Open();

                using (SQLiteCommand cmd = sqLite.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    return cmd.Materialize(materializeTable).ToList();
                }
            }
        }
    }
}
