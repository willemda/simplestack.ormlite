namespace SimpleStack.OrmLite.Oracle
{
    public class OracleDialect
    {
        public static IOrmLiteDialectProvider Provider { get { return OracleOrmLiteDialectProvider.Instance; } }
    }
}