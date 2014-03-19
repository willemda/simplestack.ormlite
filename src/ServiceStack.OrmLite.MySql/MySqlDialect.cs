using SimpleStack.OrmLite.MySql;

namespace SimpleStack.OrmLite
{
    public static class MySqlDialect
    {
        public static IOrmLiteDialectProvider Provider { get { return MySqlDialectProvider.Instance; } }
    }
}