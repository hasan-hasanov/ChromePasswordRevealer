using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChromePasswordRevealer.Data.DataContext.Abstract
{
    public interface IContext
    {
        List<T> ExecuteQuery<T>(string query, Func<IDataRecord, T> func);
    }
}
