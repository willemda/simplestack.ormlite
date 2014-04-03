using SimpleStack.OrmLite.PostgreSQL;

namespace SimpleStack.OrmLite
{
    public static class PostgreSqlDialect
    {
        public static IOrmLiteDialectProvider Provider { get { return PostgreSQLDialectProvider.Instance; } }
    }
}