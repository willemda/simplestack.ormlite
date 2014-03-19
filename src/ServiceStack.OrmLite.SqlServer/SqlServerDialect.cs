using SimpleStack.OrmLite.SqlServer;

namespace SimpleStack.OrmLite
{
    public static class SqlServerDialect
    {
        public static IOrmLiteDialectProvider Provider { get { return SqlServerOrmLiteDialectProvider.Instance; } }
    }
}