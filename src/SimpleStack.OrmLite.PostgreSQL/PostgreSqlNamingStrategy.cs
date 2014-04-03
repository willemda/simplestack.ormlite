using System;
using SimpleStack.Common;

namespace SimpleStack.OrmLite.PostgreSQL
{
    public class PostgreSqlNamingStrategy : INamingStrategy
    {
        public string GetTableName(string name)
        {
            return name.ToLowercaseUnderscore();
        }

        public string GetColumnName(string name)
        {
            return name.ToLowercaseUnderscore();
        }
    }
}