using SimpleStack.OrmLite.Firebird;

namespace SimpleStack.OrmLite
{
    public static class FirebirdDialect
    {
        public static IOrmLiteDialectProvider Provider { get { return FirebirdOrmLiteDialectProvider.Instance; } }
    }
}