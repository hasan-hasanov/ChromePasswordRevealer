﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChromePasswordRevealer.Data.Context.Abstract
{
    public interface IContext
    {
        IEnumerable<T> ExecuteQuery<T>(string query, Func<IDataRecord, T> func);
    }
}
