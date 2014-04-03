using SimpleStack.OrmLite.Sqlite;

namespace SimpleStack.OrmLite
{
    public static class SqliteDialect
    {
        public static IOrmLiteDialectProvider Provider { get { return SqliteOrmLiteDialectProvider.Instance; } }
    }
}