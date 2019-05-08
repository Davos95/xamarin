using System;
using System.Collections.Generic;
using System.Text;

namespace BasesDatos.Dependencies
{
    public interface IDataBase
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
